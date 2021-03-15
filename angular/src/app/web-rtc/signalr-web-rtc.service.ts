import { Injectable } from '@angular/core';
import { HubConnection } from '@aspnet/signalr';
import { Subject, Subscription } from 'rxjs';

import { SignalInfo, UserInfo } from './web-rtc.service';

@Injectable({
  providedIn: 'root',
})
export class SignalRWebRtcService {

  private webRtcHub: HubConnection = null;
  public subscriptions = new Subscription();

  private newPeer = new Subject<UserInfo>();
  public newPeer$ = this.newPeer.asObservable();

  private helloAnswer = new Subject<UserInfo>();
  public helloAnswer$ = this.helloAnswer.asObservable();

  private disconnectedPeer = new Subject<UserInfo>();
  public disconnectedPeer$ = this.disconnectedPeer.asObservable();

  private signal = new Subject<SignalInfo>();
  public signal$ = this.signal.asObservable();

  public connect(currentUser: string) {
    console.log("Connecting to web rtc service");

    abp.signalr.startConnection(abp.appPath + 'signalr-webrtc', () => { 
      // Connection started
    }).then((connection) => {
      this.webRtcHub = connection;

      this.webRtcHub.on('getMessage', (message) => {
        console.log('received message: ' + message);
      });

      this.webRtcHub.on('NewUserArrived', (data) => {
        console.log('received message: ' + data);
        this.newPeer.next(JSON.parse(data));
      });

      this.webRtcHub.on('UserSaidHello', (data) => {
        this.helloAnswer.next(JSON.parse(data));
      });

      this.webRtcHub.on('UserDisconnect', (data) => {
        this.disconnectedPeer.next(JSON.parse(data));
      });

      this.webRtcHub.on('SendSignal', (user, signal) => {
        console.log("ON SEND SIGNAL");
        this.signal.next({ user, signal });
      });

      this.webRtcHub.invoke('NewUser', currentUser);
    });
  }

  public sendSignalToUser(signal: string, user: string) {
    this.webRtcHub.invoke('SendSignal', signal, user);
  }

  public sayHello(userName: string, user: string): void {
    this.webRtcHub.invoke('HelloUser', userName, user);
  }
}
