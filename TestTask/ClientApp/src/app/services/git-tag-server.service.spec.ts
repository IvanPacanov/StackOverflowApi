import { TestBed } from '@angular/core/testing';

import { GitTagServerService } from './git-tag-server.service';

describe('GitTagServerService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: GitTagServerService = TestBed.get(GitTagServerService);
    expect(service).toBeTruthy();
  });
});
