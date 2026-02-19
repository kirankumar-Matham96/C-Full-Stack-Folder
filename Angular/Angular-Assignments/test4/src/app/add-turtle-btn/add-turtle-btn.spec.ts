import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddTurtleBtn } from './add-turtle-btn';

describe('AddTurtleBtn', () => {
  let component: AddTurtleBtn;
  let fixture: ComponentFixture<AddTurtleBtn>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddTurtleBtn]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddTurtleBtn);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
