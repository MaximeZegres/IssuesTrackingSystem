import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddOrUdpateIssueComponent } from './add-or-udpate-issue.component';

describe('AddOrUdpateIssueComponent', () => {
  let component: AddOrUdpateIssueComponent;
  let fixture: ComponentFixture<AddOrUdpateIssueComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddOrUdpateIssueComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddOrUdpateIssueComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
