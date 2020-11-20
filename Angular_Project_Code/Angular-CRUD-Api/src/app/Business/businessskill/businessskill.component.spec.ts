import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BusinessskillComponent } from './businessskill.component';

describe('BusinessskillComponent', () => {
  let component: BusinessskillComponent;
  let fixture: ComponentFixture<BusinessskillComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BusinessskillComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BusinessskillComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
