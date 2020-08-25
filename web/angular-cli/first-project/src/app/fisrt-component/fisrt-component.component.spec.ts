import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FisrtComponentComponent } from './fisrt-component.component';

describe('FisrtComponentComponent', () => {
  let component: FisrtComponentComponent;
  let fixture: ComponentFixture<FisrtComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FisrtComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FisrtComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
