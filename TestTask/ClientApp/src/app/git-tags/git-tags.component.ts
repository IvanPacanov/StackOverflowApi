import { Component, OnInit, Inject } from '@angular/core';
import { MostPopularTag } from '../entities/mostPopularTag';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { NgModel } from '@angular/forms';
import { GitTagServerService } from '../services/git-tag-server.service';

@Component({
  selector: 'app-git-tags',
  templateUrl: './git-tags.component.html',
  styleUrls: ['./git-tags.component.css']
})
export class GitTagsComponent {
  popularTags: Observable<MostPopularTag[]>;
  size: number;
  info:boolean = true;
  constructor(private http: GitTagServerService) { 

    
    this.popularTags = this.http.getTagsOfSize(30);
  }


  validate(value: NgModel)
  {
    if(this.isNumeric(value.value))
    {
      if(value.value > 100)
      {
        value.reset();
        this.size = 100;
      }
      else if(value.value <= 0)
      {
        value.reset();
        this.size = 1;
      }
    }else{
      value.reset();
    }  
  }
  onSubmit() {
    if(this.size == null)
    {
      this.info = true;
    }else{
      this.info = false;
    }
    this.popularTags = this.http.getTagsOfSize(this.size);
  }
  isNumeric(value) {
    return /^\d+$/.test(value);
}

}
