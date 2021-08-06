import { AfterContentInit, Component, Input, OnInit } from '@angular/core';
import { MostPopularTag } from '../../entities/mostPopularTag';

@Component({
  selector: 'app-tag-card',
  templateUrl: './tag-card.component.html',
  styleUrls: ['./tag-card.component.css']
})
export class TagCardComponent implements AfterContentInit {
  @Input() tag: MostPopularTag;
  @Input() count: number;
  @Input() size: number;
 
  constructor() {      
   
  }
  ngAfterContentInit(): void {
   console.log();
  }


}

