import { Pipe, PipeTransform } from '@angular/core';
import { Person } from './person';

@Pipe({
  name: 'reverse'
})
export class ReversePipe implements PipeTransform {

  transform(name: string, ...args: unknown[]): any {
    var res:string[]=[];
    var result:string='';
    for(var i=name.length-1;i>=0;i--){

        res.push(name[i]);

    }
    result=res.join('')
    return result;
  }

}
