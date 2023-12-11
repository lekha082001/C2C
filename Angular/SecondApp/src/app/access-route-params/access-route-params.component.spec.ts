import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AccessRouteParamsComponent } from './access-route-params.component';

describe('AccessRouteParamsComponent', () => {
  let component: AccessRouteParamsComponent;
  let fixture: ComponentFixture<AccessRouteParamsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AccessRouteParamsComponent]
    });
    fixture = TestBed.createComponent(AccessRouteParamsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
