import { TestBed } from '@angular/core/testing';

import { TruckModelService } from './truck-model.service';

describe('TruckModelService', () => {
  let service: TruckModelService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TruckModelService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
