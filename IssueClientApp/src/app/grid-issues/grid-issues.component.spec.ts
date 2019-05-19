import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GridIssuesComponent } from './grid-issues.component';

describe('GridIssuesComponent', () => {
  let component: GridIssuesComponent;
  let fixture: ComponentFixture<GridIssuesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GridIssuesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GridIssuesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
