import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
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

  get_employee_byID(EmployeeID:number): Observable<employees>{
    let url = `${this.api_url}/employees/${EmployeeID}`;
    return this.http.get<employees>(url);
  }

  add(employee: employees): Observable<employees> {
    return this.http.post<employees>(this.api_url, employee);
  }

  delete(EmployeeID:number): Observable<employees>{
    let url = `${this.api_url}/employees/${EmployeeID}`
    return this.http.delete<employees>(url);
  }

  update(employee: employees): Observable<employees>{
    let url = `${this.api_url}/employees/${employee.EmployeeID}`
    return this.http.put<employees>(url, employee);
  }
}
