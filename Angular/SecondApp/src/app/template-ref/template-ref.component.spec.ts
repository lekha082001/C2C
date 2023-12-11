import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemplateRefComponent } from './template-ref.component';

describe('TemplateRefComponent', () => {
  let component: TemplateRefComponent;
  let fixture: ComponentFixture<TemplateRefComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TemplateRefComponent]
    });
    fixture = TestBed.createComponent(TemplateRefComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
