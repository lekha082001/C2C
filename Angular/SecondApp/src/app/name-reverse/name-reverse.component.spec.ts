import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NameReverseComponent } from './name-reverse.component';

describe('NameReverseComponent', () => {
  let component: NameReverseComponent;
  let fixture: ComponentFixture<NameReverseComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NameReverseComponent]
    });
    fixture = TestBed.createComponent(NameReverseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
