import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { response_dto } from 'src/app/core/model/response-dto';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class employees_service {
  api_url:string = environment.api_lab;

  constructor( private http:HttpClient ) { }

  get_employees() : Observable<response_dto>{
    
    let url = `${this.api_url}/employees`;
    return this.http.get<response_dto>(url);
  }
}
