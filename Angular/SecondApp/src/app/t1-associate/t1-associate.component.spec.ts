import { ComponentFixture, TestBed } from '@angular/core/testing';

import { T1AssociateComponent } from './t1-associate.component';

describe('T1AssociateComponent', () => {
  let component: T1AssociateComponent;
  let fixture: ComponentFixture<T1AssociateComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [T1AssociateComponent]
    });
    fixture = TestBed.createComponent(T1AssociateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
