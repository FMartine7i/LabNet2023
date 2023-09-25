import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { employees_service } from 'src/app/components/service/employees.services.service';
import { employees } from 'src/app/core/model/employee-models';

@Component({
  selector: 'app-employee-edit',
  templateUrl: './employee-edit.component.html',
  styleUrls: ['./employee-edit.component.css']
})
export class EmployeeEditComponent {
  employee: employees;

  constructor(
    private dialogRef: MatDialogRef<EmployeeEditComponent>,
    @Inject(MAT_DIALOG_DATA) data: any,
    private _employee_service: employees_service
  ){
    this.employee = data.employee;
  }

  onSubmit(){
    this._employee_service.update(this.employee).subscribe({
      next: (result) =>{
        console.log('Employee updated', result);
        this.dialogRef.close({ succes: true });
      },
      error: (error) =>{
        console.error('Error updating employee', error);
      }
    })
  };

  onCancel(){
    this.dialogRef.close({ succes: false });
  }
}
