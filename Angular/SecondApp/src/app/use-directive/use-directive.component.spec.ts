import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UseDirectiveComponent } from './use-directive.component';

describe('UseDirectiveComponent', () => {
  let component: UseDirectiveComponent;
  let fixture: ComponentFixture<UseDirectiveComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UseDirectiveComponent]
    });
    fixture = TestBed.createComponent(UseDirectiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
