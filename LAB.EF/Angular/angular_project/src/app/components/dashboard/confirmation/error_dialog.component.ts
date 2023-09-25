import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-error-dialog',
  template: `
    <div style="width: 350px; height: 200px; display: flex; justify-content: center; align-items: center; flex-direction: column;">
        <div>
            <h1>Error</h1>
            <p>{{ data.message }}</p>
            <div style="display: flex; justify-content: center;">
                <button style="border: 1px solid #787878; background: #787878; border-radius: 10px; height: 2.3rem; width: 3rem" mat-button (click)="onClose()">OK</button>
            <div>
        </div>
    </div>
  `,
})
export class ErrorDialogComponent {
  constructor(
    public dialogRef: MatDialogRef<ErrorDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {}

  onClose(): void {
    this.dialogRef.close();
  }
}