import { CommonModule } from '@angular/common';
import { HttpClientJsonpModule, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AboutComponent } from '@app/about/about.component';
import { HomeComponent } from '@app/home/home.component';
import { RolesComponent } from '@app/roles/roles.component';
import { TenantsComponent } from '@app/tenants/tenants.component';
import { CreateUserDialogComponent } from '@app/users/create-user/create-user-dialog.component';
import { EditUserDialogComponent } from '@app/users/edit-user/edit-user-dialog.component';
import { UsersComponent } from '@app/users/users.component';
import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';
import { SharedModule } from '@shared/shared.module';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ModalModule } from 'ngx-bootstrap/modal';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { NgxPaginationModule } from 'ngx-pagination';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './layout/footer.component';
import { HeaderLanguageMenuComponent } from './layout/header-language-menu.component';
import { HeaderLeftNavbarComponent } from './layout/header-left-navbar.component';
import { HeaderUserMenuComponent } from './layout/header-user-menu.component';
import { HeaderComponent } from './layout/header.component';
import { SidebarLogoComponent } from './layout/sidebar-logo.component';
import { SidebarMenuComponent } from './layout/sidebar-menu.component';
import { SidebarUserPanelComponent } from './layout/sidebar-user-panel.component';
import { SidebarComponent } from './layout/sidebar.component';
import { CreateRoleDialogComponent } from './roles/create-role/create-role-dialog.component';
import { EditRoleDialogComponent } from './roles/edit-role/edit-role-dialog.component';
import { CreateTenantDialogComponent } from './tenants/create-tenant/create-tenant-dialog.component';
import { EditTenantDialogComponent } from './tenants/edit-tenant/edit-tenant-dialog.component';
import { ChangePasswordComponent } from './users/change-password/change-password.component';
import { ResetPasswordDialogComponent } from './users/reset-password/reset-password.component';
import { SignalRWebRtcService } from './web-rtc/signalr-web-rtc.service';
import { WebRtcRoomComponent } from './web-rtc/web-rtc-room.component';
import { WebRtcUserListComponent } from './web-rtc/web-rtc-user-list-component/web-rtc-user-list.component';
import { WebRtcService } from './web-rtc/web-rtc.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    // tenants
    TenantsComponent,
    CreateTenantDialogComponent,
    EditTenantDialogComponent,
    // roles
    RolesComponent,
    CreateRoleDialogComponent,
    EditRoleDialogComponent,
    // users
    UsersComponent,
    CreateUserDialogComponent,
    EditUserDialogComponent,
    ChangePasswordComponent,
    ResetPasswordDialogComponent,
    // layout
    HeaderComponent,
    HeaderLeftNavbarComponent,
    HeaderLanguageMenuComponent,
    HeaderUserMenuComponent,
    FooterComponent,
    SidebarComponent,
    SidebarLogoComponent,
    SidebarUserPanelComponent,
    SidebarMenuComponent,
    // web rtc
    WebRtcRoomComponent,
    WebRtcUserListComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    HttpClientJsonpModule,
    ModalModule.forChild(),
    BsDropdownModule,
    CollapseModule,
    TabsModule,
    AppRoutingModule,
    ServiceProxyModule,
    SharedModule,
    NgxPaginationModule,
  ],
  providers: [
    WebRtcService,
    SignalRWebRtcService,
  ],
  entryComponents: [
    // tenants
    CreateTenantDialogComponent,
    EditTenantDialogComponent,
    // roles
    CreateRoleDialogComponent,
    EditRoleDialogComponent,
    // users
    CreateUserDialogComponent,
    EditUserDialogComponent,
    ResetPasswordDialogComponent,
  ],
})
export class AppModule {}
