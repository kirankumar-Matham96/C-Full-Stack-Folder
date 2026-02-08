import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DateAndTime } from './date-and-time';

describe('DateAndTime', () => {
  let component: DateAndTime;
  let fixture: ComponentFixture<DateAndTime>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DateAndTime]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DateAndTime);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
