import { AfterContentInit, Component, ContentChild } from '@angular/core';
import { T3ChildComponent } from '../t3-child/t3-child.component';

@Component({
  selector: 'app-t3-container',
  templateUrl: './t3-container.component.html',
  styleUrls: ['./t3-container.component.css']
})
export class T3ContainerComponent implements AfterContentInit {
  @ContentChild(T3ChildComponent) child!: T3ChildComponent;
  ngAfterContentInit(): void {
    console.log(this.child);
  }

}
