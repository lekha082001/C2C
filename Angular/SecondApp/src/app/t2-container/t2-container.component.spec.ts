import { ComponentFixture, TestBed } from '@angular/core/testing';

import { T2ContainerComponent } from './t2-container.component';

describe('T2ContainerComponent', () => {
  let component: T2ContainerComponent;
  let fixture: ComponentFixture<T2ContainerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [T2ContainerComponent]
    });
    fixture = TestBed.createComponent(T2ContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
