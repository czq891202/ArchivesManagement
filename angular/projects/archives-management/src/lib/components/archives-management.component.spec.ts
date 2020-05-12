import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ArchivesManagementComponent } from './archives-management.component';

describe('ArchivesManagementComponent', () => {
  let component: ArchivesManagementComponent;
  let fixture: ComponentFixture<ArchivesManagementComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ArchivesManagementComponent],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ArchivesManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
