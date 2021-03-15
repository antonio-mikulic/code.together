import { ChangeDetectionStrategy, Component, EventEmitter, Injector, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { Observable } from 'rxjs';

import { UserInfo, WebRtcService } from '../web-rtc.service';


@Component({
    selector: 'web-rtc-user-list',
    templateUrl: './web-rtc-user-list.component.html',
    animations: [appModuleAnimation()],
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class WebRtcUserListComponent extends AppComponentBase {
    @Output() userSelected: EventEmitter<UserInfo> = new EventEmitter();

    public users$: Observable<Array<UserInfo>>;

    constructor(
        injector: Injector,
        private rtcService: WebRtcService
    ) {
        super(injector);
    }

    ngOnInit() {
        this.users$ = this.rtcService.users$;
    }

    public userClicked(user: UserInfo) {
        this.userSelected.emit(user);
    }

}
