import { Component } from '@angular/core';

@Component({
  selector: 'app-template-ref',
  templateUrl: './template-ref.component.html',
  styleUrls: ['./template-ref.component.css']
})
export class TemplateRefComponent {
changeBackground(_t4: any) {
  _t4.style="background-color:red";
}
dontDisturb(_t2: any) {
_t2.style="background-color:grey";
}
switchOff(_t2: any) {
_t2.style="background-color:black";
}
lightUp(_t2: any) {
_t2.style="background-color:orange";
}

}
