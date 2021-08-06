import { AfterContentChecked, AfterContentInit, Component, DoCheck, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { MostPopularTag } from '../../entities/mostPopularTag';

@Component({
  selector: 'app-tag-card',
  templateUrl: './tag-card.component.html',
  styleUrls: ['./tag-card.component.css']
})
export class TagCardComponent {
  @Input() tag: MostPopularTag;
  @Input() count: number;
  @Input() size: number;
  
 
  constructor() {      
  }




}

