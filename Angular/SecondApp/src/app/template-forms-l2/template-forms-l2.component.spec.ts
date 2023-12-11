import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemplateFormsL2Component } from './template-forms-l2.component';

describe('TemplateFormsL2Component', () => {
  let component: TemplateFormsL2Component;
  let fixture: ComponentFixture<TemplateFormsL2Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TemplateFormsL2Component]
    });
    fixture = TestBed.createComponent(TemplateFormsL2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
