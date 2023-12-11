import { ComponentFixture, TestBed } from '@angular/core/testing';

import { T1ContainerComponent } from './t1-container.component';

describe('T1ContainerComponent', () => {
  let component: T1ContainerComponent;
  let fixture: ComponentFixture<T1ContainerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [T1ContainerComponent]
    });
    fixture = TestBed.createComponent(T1ContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
