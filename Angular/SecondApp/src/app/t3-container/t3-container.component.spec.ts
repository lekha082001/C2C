import { ComponentFixture, TestBed } from '@angular/core/testing';

import { T3ContainerComponent } from './t3-container.component';

describe('T3ContainerComponent', () => {
  let component: T3ContainerComponent;
  let fixture: ComponentFixture<T3ContainerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [T3ContainerComponent]
    });
    fixture = TestBed.createComponent(T3ContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
