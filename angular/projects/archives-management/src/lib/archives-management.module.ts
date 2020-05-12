import { NgModule } from '@angular/core';
import { ArchivesManagementComponent } from './components/archives-management.component';
import { ArchivesManagementRoutingModule } from './archives-management-routing.module';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CoreModule } from '@abp/ng.core';

@NgModule({
  declarations: [ArchivesManagementComponent],
  imports: [CoreModule, ThemeSharedModule, ArchivesManagementRoutingModule],
  exports: [ArchivesManagementComponent],
})
export class ArchivesManagementModule {}
