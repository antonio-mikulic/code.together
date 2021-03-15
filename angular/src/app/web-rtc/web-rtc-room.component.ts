import { ChangeDetectionStrategy, Component, ElementRef, Injector, OnInit, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { Subject, Subscription } from 'rxjs';

import { SignalRWebRtcService } from './signalr-web-rtc.service';
import { ChatMessage, PeerData, SignalInfo, UserInfo, WebRtcService } from './web-rtc.service';

@Component({
  templateUrl: './web-rtc-room.component.html',
  animations: [appModuleAnimation()],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class WebRtcRoomComponent extends AppComponentBase implements OnInit {
  @ViewChild('videoPlayer') videoPlayer: ElementRef;

  private stream;

  public currentUser: string;

  public dataString: string;

  public userVideo: string;

  public messages: Array<ChatMessage>;

  public mediaError = (): void => { console.error(`Can't get user media`); };

  public subscriptions = new Subscription();

  private newPeer = new Subject<UserInfo>();
  public newPeer$ = this.newPeer.asObservable();

  private helloAnswer = new Subject<UserInfo>();
  public helloAnswer$ = this.helloAnswer.asObservable();

  private disconnectedPeer = new Subject<UserInfo>();
  public disconnectedPeer$ = this.disconnectedPeer.asObservable();

  private signal = new Subject<SignalInfo>();
  public signal$ = this.signal.asObservable();

  constructor(
    injector: Injector,
    private webRtcService: WebRtcService,
    private signalR: SignalRWebRtcService
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this.connect();
  }

  private connect() {
    this.messages = new Array();

    this.subscriptions.add(this.signalR.newPeer$.subscribe((user: UserInfo) => {
      console.log("NEw peer found: ", user);
      this.webRtcService.newUser(user);
      this.signalR.sayHello(this.currentUser, user.connectionId);
    }));

    this.subscriptions.add(this.signalR.helloAnswer$.subscribe((user: UserInfo) => {
      console.log("Someone else is saying hello: ", user);
      this.webRtcService.newUser(user);
    }));

    this.subscriptions.add(this.signalR.disconnectedPeer$.subscribe((user: UserInfo) => {
      this.webRtcService.disconnectedUser(user);
    }));

    this.subscriptions.add(this.signalR.signal$.subscribe((signalData: SignalInfo) => {
      console.log("Signal R finished...");
      this.webRtcService.signalPeer(signalData.user, signalData.signal, this.stream);
    }));

    this.subscriptions.add(this.webRtcService.onSignalToSend$.subscribe((data: PeerData) => {
      this.signalR.sendSignalToUser(data.data, data.id);
    }));

    this.subscriptions.add(this.webRtcService.onData$.subscribe((data: PeerData) => {
      console.log(`Data from user ${data.id}: ${data.data}`);
    }));

    this.subscriptions.add(this.webRtcService.onStream$.subscribe((data: PeerData) => {
      this.userVideo = data.id;
      this.videoPlayer.nativeElement.srcObject = data.data;
      this.videoPlayer.nativeElement.load();
      this.videoPlayer.nativeElement.play();
    }));
  }

  public onUserSelected(userInfo: UserInfo) {
    const peer = this.webRtcService.createPeer(this.stream, userInfo.connectionId, true);
    this.webRtcService.currentPeer = peer;
  }

  public async saveUsername(): Promise<void> {
    try {
      this.signalR.connect(this.currentUser);
      this.stream = await navigator.mediaDevices.getUserMedia({ video: true, audio: true });
      console.log("Got stream: ", this.stream);
    } catch (error) {
      console.error(`Can't join room, error ${error}`);
    }
  }

  public sendMessage() {
    this.webRtcService.sendMessage(this.dataString);
    this.messages = [...this.messages, { own: true, message: this.dataString }];
    this.dataString = null;
  }

  ngOnDestroy() {
    this.subscriptions.unsubscribe();
  }

}
