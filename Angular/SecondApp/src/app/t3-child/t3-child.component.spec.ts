import { ComponentFixture, TestBed } from '@angular/core/testing';

import { T3ChildComponent } from './t3-child.component';

describe('T3ChildComponent', () => {
  let component: T3ChildComponent;
  let fixture: ComponentFixture<T3ChildComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [T3ChildComponent]
    });
    fixture = TestBed.createComponent(T3ChildComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
