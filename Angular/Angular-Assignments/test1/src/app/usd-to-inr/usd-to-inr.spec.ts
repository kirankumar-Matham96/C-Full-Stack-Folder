import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsdToInr } from './usd-to-inr';

describe('UsdToInr', () => {
  let component: UsdToInr;
  let fixture: ComponentFixture<UsdToInr>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UsdToInr]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UsdToInr);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
