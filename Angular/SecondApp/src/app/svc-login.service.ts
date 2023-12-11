import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})  //same as AddingSingleton<>() in MVC
export class SvcLoginService {

  constructor(private http:HttpClient) { }

  public login(email:string, pwd:string){
    let url="https://reqres.in/api/login";
    let body= {
                email: email,
                password: pwd
              };
    return this.http.post(url,body);
  }
}
