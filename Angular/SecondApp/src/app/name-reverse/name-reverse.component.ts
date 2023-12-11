import { Component } from '@angular/core';
import { Person } from '../person';

@Component({
  selector: 'app-name-reverse',
  templateUrl: './name-reverse.component.html',
  styleUrls: ['./name-reverse.component.css']
})
export class NameReverseComponent {
valuetoreverse: Person[]=[];
personList: any;

}
