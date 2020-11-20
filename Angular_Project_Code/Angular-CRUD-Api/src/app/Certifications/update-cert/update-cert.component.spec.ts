import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateCertComponent } from './update-cert.component';

describe('UpdateCertComponent', () => {
  let component: UpdateCertComponent;
  let fixture: ComponentFixture<UpdateCertComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UpdateCertComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateCertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
