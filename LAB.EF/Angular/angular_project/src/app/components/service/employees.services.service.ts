import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { response_dto } from 'src/app/core/model/response-dto';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { employees } from 'src/app/core/model/employee-models';

@Injectable({
  providedIn: 'root'
})
export class employees_service {
  api_url:string = environment.api_lab;

  constructor( private http:HttpClient ) { }

  get_employees() {   
    let url = `${this.api_url}/employees`;
    console.log("Calling GET on " + url);
    console.log(employees_service)
    return this.http.get<employees[]>(url);
  }
}
