import { Component, OnInit, Inject } from '@angular/core';
import { MostPopularTag } from '../entities/mostPopularTag';
import { Observable, } from 'rxjs';
import {map} from 'rxjs/operators'
import { NgModel } from '@angular/forms';
import { GitTagServerService } from '../services/git-tag-server.service';
import { ConfigureToSearch } from '../entities/configureToSearch';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-git-tags',
  templateUrl: './git-tags.component.html',
  styleUrls: ['./git-tags.component.css']
})
export class GitTagsComponent {
  popularTags: MostPopularTag[];
  configureToSearch: Partial<ConfigureToSearch> = {
    size: 100, order: "desc", sort: "popular" };
  sizeOfEle: number = 100;
  info:boolean = true;
  newIsError:boolean = false;
  constructor(private http: GitTagServerService) { 
  this.http.getTags().subscribe(result => {
    this.popularTags = result
    if(result[1].isError)
        this.myFunction()
  });
 
    
  }  
  
  OnNewIsError(val: string)
  {
console.log(val)
  }

  myFunction() {
    alert("Na serwerze wystapił bład! Zostały pobrane surowe dane z serwera z domyślnymi ustawieniami. (Najprawdopodoniej przekroczono ilość zapytań do API).");
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
    console.log("Test");
    if(this.configureToSearch.size == null)
    {
      this.info = true;
    }else{
      this.info = false;
    }
    this.sizeOfEle = this.configureToSearch.size;
    this.http.getTagsOfSize(this.configureToSearch as ConfigureToSearch).subscribe(result => {
      this.popularTags = result
      if(result[1].isError)
      this.myFunction()
});
  }

  isNumeric(value) {
    return /^\d+$/.test(value);
}

}
