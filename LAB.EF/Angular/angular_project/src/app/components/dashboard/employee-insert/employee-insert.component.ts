import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { employees_service } from 'src/app/components/service/employees.services.service';
import { employees } from 'src/app/core/model/employee-models';

@Component({
  selector: 'app-employee-insert',
  templateUrl: './employee-insert.component.html',
  styleUrls: ['./employee-insert.component.css']
})
export class EmployeeInsertComponent {
  employee: employees;

  constructor(
    @Inject(MAT_DIALOG_DATA) data: any,
    private dialogRef: MatDialogRef<EmployeeInsertComponent>,
    private _employee_service: employees_service) 
    {
      this.employee = data.employee;
    }

    onSubmit() {
      this._employee_service.add(this.employee).subscribe({
        next: (result) =>{
          console.log('Employee created', result);
          this.dialogRef.close( {success: true} );
        },
        error: (e) =>{
          console.error('Error creating employee', e);
        }
      })
    }

    onCancel(){
      this.dialogRef.close( {success: true});
    }
}
