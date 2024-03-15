import { TestBed } from '@angular/core/testing';
import { LuckyDrawService } from './services/lucky-draw.service';
import { RestService } from '@abp/ng.core';

describe('LuckyDrawService', () => {
  let service: LuckyDrawService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(LuckyDrawService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
