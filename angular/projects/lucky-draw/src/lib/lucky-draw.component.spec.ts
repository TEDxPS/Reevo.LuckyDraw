import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { LuckyDrawComponent } from './components/lucky-draw.component';
import { LuckyDrawService } from '@reevo/lucky-draw';
import { of } from 'rxjs';

describe('LuckyDrawComponent', () => {
  let component: LuckyDrawComponent;
  let fixture: ComponentFixture<LuckyDrawComponent>;
  const mockLuckyDrawService = jasmine.createSpyObj('LuckyDrawService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [LuckyDrawComponent],
      providers: [
        {
          provide: LuckyDrawService,
          useValue: mockLuckyDrawService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LuckyDrawComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
