import { Injectable } from '@angular/core';
import { eLayoutType, addAbpRoutes, ABP } from '@abp/ng.core';
import { addSettingTab } from '@abp/ng.theme.shared';
import { ArchivesManagementSettingsComponent } from '../components/archives-management-settings.component';

@Injectable({
  providedIn: 'root',
})
export class ArchivesManagementConfigService {
  constructor() {
    addAbpRoutes({
      name: 'ArchivesManagement',
      path: 'archives-management',
      layout: eLayoutType.application,
      order: 2,
    } as ABP.FullRoute);

    const route = addSettingTab({
      component: ArchivesManagementSettingsComponent,
      name: 'ArchivesManagement Settings',
      order: 1,
      requiredPolicy: '',
    });
  }
}
