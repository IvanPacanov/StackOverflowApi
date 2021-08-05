import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GitTagsComponent } from './git-tags.component';

describe('GitTagsComponent', () => {
  let component: GitTagsComponent;
  let fixture: ComponentFixture<GitTagsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GitTagsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GitTagsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
