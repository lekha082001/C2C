import { Pipe, PipeTransform } from '@angular/core';
import { Person } from './person';

@Pipe({
  name: 'search'
})
export class SearchPipe implements PipeTransform {

  transform(people: any, ...args: unknown[]): any[] {
    //var people = Person.GetPeople();
    var result:Person[]=[];
    for(let i=0;i<people.length;i++){
      if(people[i].name.includes(args[0])){
        result.push(people[i]);
      }
    }
    return result;
  }

}
