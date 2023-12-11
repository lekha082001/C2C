import { TestBed } from '@angular/core/testing';

import { SvcLoginService } from './svc-login.service';

describe('SvcLoginService', () => {
  let service: SvcLoginService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SvcLoginService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
