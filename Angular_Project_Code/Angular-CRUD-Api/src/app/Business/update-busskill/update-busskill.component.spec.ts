import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateBusskillComponent } from './update-busskill.component';

describe('UpdateBusskillComponent', () => {
  let component: UpdateBusskillComponent;
  let fixture: ComponentFixture<UpdateBusskillComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UpdateBusskillComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateBusskillComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
