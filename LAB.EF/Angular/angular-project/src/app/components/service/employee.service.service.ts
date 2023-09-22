import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { response_dto } from 'src/app/core/models/response_dto';
import { environment } from 'src/app/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeeServiceService {
  apiURL:string = environment.api_lab;

  constructor(private http:HttpClient) { }

  getAllEmployees():Observable<response_dto> {
    let url = `${this.apiURL}/employees/GetAllEmployees`;
    return this.http.get<response_dto>(url);
  }
}
