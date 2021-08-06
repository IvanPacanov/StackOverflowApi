import { Component, OnInit, Inject } from '@angular/core';
import { MostPopularTag } from '../entities/mostPopularTag';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { NgModel } from '@angular/forms';
import { GitTagServerService } from '../services/git-tag-server.service';
import { ConfigureToSearch } from '../entities/configureToSearch';

@Component({
  selector: 'app-git-tags',
  templateUrl: './git-tags.component.html',
  styleUrls: ['./git-tags.component.css']
})
export class GitTagsComponent {
  popularTags: Observable<MostPopularTag[]>;
  configureToSearch: Partial<ConfigureToSearch> = {};
  sizeOfEle: number = 100;
  info:boolean = true;
  constructor(private http: GitTagServerService) { 
    this.popularTags = this.http.getTags();
  }


  validate(value: NgModel)
  {
    if(this.isNumeric(value.value))
    {
      if(value.value > 100)
      {
        value.reset();
        this.configureToSearch.size = 100;
      }
      else if(value.value <= 0)
      {
        value.reset();
        this.configureToSearch.size = 1;
      }
    }else{
      value.reset();
    }  
  }
  onSubmit() {
    if(this.configureToSearch.size == null)
    {
      this.info = true;
    }else{
      this.info = false;
    }
    this.sizeOfEle = this.configureToSearch.size;
    this.popularTags = this.http.getTagsOfSize(this.configureToSearch as ConfigureToSearch);
  }

  isNumeric(value) {
    return /^\d+$/.test(value);
}

}
