import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-t1-associate',
  templateUrl: './t1-associate.component.html',
  styleUrls: ['./t1-associate.component.css']
})
export class T1AssociateComponent {
@Input() message: any;
@Output() clap = new EventEmitter();

eventOutput:string = '';

}
