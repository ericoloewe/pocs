import { TestBed, inject } from '@angular/core/testing';
import { FirstServiceService } from './first-service.service';

describe('FirstServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [FirstServiceService]
    });
  });

  it('should ...', inject([FirstServiceService], (service: FirstServiceService) => {
    expect(service).toBeTruthy();
  }));
});
