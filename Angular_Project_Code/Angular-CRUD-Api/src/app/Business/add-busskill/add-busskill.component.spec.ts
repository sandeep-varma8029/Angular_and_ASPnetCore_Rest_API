import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddBusskillComponent } from './add-busskill.component';

describe('AddBusskillComponent', () => {
  let component: AddBusskillComponent;
  let fixture: ComponentFixture<AddBusskillComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddBusskillComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddBusskillComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
