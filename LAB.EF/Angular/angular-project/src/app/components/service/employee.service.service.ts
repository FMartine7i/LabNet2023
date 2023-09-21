import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/app/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EmployeeServiceService {
  apiURL:string = environment.api_lab;

  constructor(private http:HttpClient) { }
}
