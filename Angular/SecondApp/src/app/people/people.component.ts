import { Component } from '@angular/core';
import { Person } from '../person';

@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent {
personList: Person[]=[];
valuetosearch: any;

constructor(){
  this.personList=Person.GetPeople();
}

}
