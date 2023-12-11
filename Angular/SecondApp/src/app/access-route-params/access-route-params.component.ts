import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router'; 

@Component({
  selector: 'app-access-route-params',
  templateUrl: './access-route-params.component.html',
  styleUrls: ['./access-route-params.component.css']
})
export class AccessRouteParamsComponent {
paramValue: any;
constructor(private activeRoute:ActivatedRoute){}
public accessParams(){
  this.activeRoute.params.subscribe((data)=>{console.log(data)});
}
}
