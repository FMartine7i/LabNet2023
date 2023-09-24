import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { employees } from 'src/app/core/model/employee-models';
import { employees_service } from 'src/app/components/service/employees.services.service';
import { response_dto } from 'src/app/core/model/response-dto';

@Component({
  selector: 'app-employees',
  styleUrls: ['./employees.component.css'],
  templateUrl: './employees.component.html',
})
export class EmployeesComponent implements AfterViewInit {
  displayedColumns: string[] = [
    'EmployeeID', 
    'FirstName',
    'LastName', 
    'City',
    'Country',
    'edit', 
    'delete'];

  arr_employees: Array<employees> = [];

  dataSource = new MatTableDataSource<employees>(this.arr_employees);

 
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _employee_service: employees_service) {}

  ngOnInit(): void {
    console.log('Calling get_all()');
    this.get_all();
  }

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

  get_all(){
    console.log('Inside get_all()');
    this._employee_service.get_employees().subscribe({
      next: (result) => {

        console.log('API call success');

        this.dataSource.data = result;

      },
      error: (e) => {
        console.log('Error:', e);
        console.log('Full Response:', e.error);
      }
    });
  }
}

