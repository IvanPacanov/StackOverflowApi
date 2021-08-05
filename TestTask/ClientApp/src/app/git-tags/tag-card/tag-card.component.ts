import { AfterContentInit, Component, Input, OnInit } from '@angular/core';
import { MostPopularTag } from '../../entities/mostPopularTag';

@Component({
  selector: 'app-tag-card',
  templateUrl: './tag-card.component.html',
  styleUrls: ['./tag-card.component.css']
})
export class TagCardComponent{
  @Input() tag: MostPopularTag;
 
  constructor() {      
   
  }

}

