import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TurtleArmy } from './turtle-army';

describe('TurtleArmy', () => {
  let component: TurtleArmy;
  let fixture: ComponentFixture<TurtleArmy>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TurtleArmy]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TurtleArmy);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
