import { Component } from '@angular/core';
import { Person } from '../person';

@Component({
  selector: 'add-person',
  templateUrl: './add-person.component.html',
  styleUrls: ['./add-person.component.css']
})
export class AddPersonComponent {
public addPerson(pAadhar:string, pName:string, pAge:number,pAlive:boolean) {
var person = new Person(pAadhar,pName,pAge);
person.isAlive = pAlive;
Person.AddPerson(person);
this.status = `Person with name ${person.name}added succesfully!`;
}

public handleClick(s: string) {
  this.status = `You entered the state ${s}`;
return `You entered the state $(s)`;
}

  public CalculateDogYears(age: number)
  {
    return age/7;
  }

  public greeting:string = `Welcome to Karnataka People Forum.
                            Add yourself to this forum here.`
  public state:string="Karnatka"; 

  public p:Person = new Person("AA4325446757868769","Nisha",23);
  public status:string = ' ';
}
