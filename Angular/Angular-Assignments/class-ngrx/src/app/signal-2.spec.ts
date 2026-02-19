import { TestBed } from '@angular/core/testing';

import { Signal2 } from './signal-2';

describe('Signal2', () => {
  let service: Signal2;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Signal2);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
