import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoadModuleComponent } from './load-module.component';

describe('LoadModuleComponent', () => {
  let component: LoadModuleComponent;
  let fixture: ComponentFixture<LoadModuleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoadModuleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoadModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
