import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { employees } from 'src/app/core/model/employee-models';
import { employees_service } from 'src/app/components/service/employees.services.service';
import { EmployeeEditComponent } from '../employee-edit/employee-edit.component';
import { ConfirmationDialogComponent } from '../confirmation/confirmation.component';
import { SuccessDialogComponent } from '../confirmation/succes_dialog.component';
import { ErrorDialogComponent } from '../confirmation/error_dialog.component';
import { EmployeeInsertComponent } from '../employee-insert/employee-insert.component';


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

  constructor(
    private _employee_service: employees_service,
    private dialog: MatDialog
    ) {}

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


  get_all(){
    this._employee_service.get_employees().subscribe({
      next: (result) => {

        console.log('API call success');
        
        this.arr_employees = result;
        this.dataSource.data = result;

      },
      error: (e) => {
        console.log('Error:', e);
        console.log('Full Response:', e.error);
      }
    });
  }

  insert_employee(){
    console.log('creating employee');
    const dialogRef = this.dialog.open(EmployeeInsertComponent, {
      width: '350px',
    });
    
    dialogRef.afterClosed().subscribe((result)=>{
      if( result && result.succes){
        this.get_all()
      }
    })
  }

  edit_employee(EmployeeID:number){
    console.log('Editing employee with ID:', EmployeeID);

    const selected_employee = this.arr_employees.find(employee => employee.EmployeeID == EmployeeID);

    if(selected_employee){ 
      const dialogRef = this.dialog.open(EmployeeEditComponent, {
      width: '350px', 
      data: {employee: selected_employee} 
    });
  
    dialogRef.afterClosed().subscribe((result) => {
      if (result && result.success) {
        this.get_all(); 
        }
      });
    }
    else{
      console.log("employee not selected")
    };
  }

delete_employee(EmployeeID: number) {
  const dialogRef = this.dialog.open(ConfirmationDialogComponent);

  dialogRef.afterClosed().subscribe((result) => {
    if (result) {
      this._employee_service.delete(EmployeeID).subscribe(
        () => {
          this.get_all();
          this.openSuccessDialog('Employee deleted.');
        },
        (error) => {
          console.error('Error: ', error);
          this.openErrorDialog('Error deleting employee.');
        }
      );
    }
  });
}

private openSuccessDialog(message: string) {
  this.dialog.open(SuccessDialogComponent, {
    data: { message },
  });
}

private openErrorDialog(message: string) {
  this.dialog.open(ErrorDialogComponent, {
    data: { message },
  });
}

}

