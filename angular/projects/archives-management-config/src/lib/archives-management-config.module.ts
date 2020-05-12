import { NgModule, APP_INITIALIZER } from '@angular/core';
import { ArchivesManagementConfigService } from './services/archives-management-config.service';
import { noop } from '@abp/ng.core';
import { ArchivesManagementSettingsComponent } from './components/archives-management-settings.component';

@NgModule({
  declarations: [ArchivesManagementSettingsComponent],
  providers: [{ provide: APP_INITIALIZER, deps: [ArchivesManagementConfigService], multi: true, useFactory: noop }],
  exports: [ArchivesManagementSettingsComponent],
  entryComponents: [ArchivesManagementSettingsComponent],
})
export class ArchivesManagementConfigModule {}
