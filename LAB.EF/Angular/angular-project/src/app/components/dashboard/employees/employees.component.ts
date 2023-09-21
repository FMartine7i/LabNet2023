import {AfterViewInit, Component, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import {MatTableDataSource, MatTableModule} from '@angular/material/table';
import { employee } from 'src/app/core/models/employee_model';

@Component({
  selector: 'app-employees',
  styleUrls: ['./employees.component.css'],
  templateUrl: './employees.component.html',
})
export class EmployeesComponent implements AfterViewInit {
  displayedColumns: string[] = ['id', 'first_name', 'last_name', 'hire_date', 'city', 'edit', 'delete'];
  dataSource = new MatTableDataSource<employee>(list_employees);

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  edit_employee(employee_name:string){
    console.log('Edit: ', employee_name)
  }

  delete_employee(employee_name:string){
    console.log('Delete: ', employee_name)
  }
}


const list_employees: employee[] = [
  {id: 1, first_name: 'Federico', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia Blanca"},
  {id: 2, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "sdsoxclqwpeoip"},
  {id: 3, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 4, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 5, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 6, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 7, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 8, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 9, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 10, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 11, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 12, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 13, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 14, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
  {id: 15, first_name: 'Fede', last_name: 'Martinetti',hire_date: new Date('2023-09-20T00:00:00'), city: "Bahia"},
];