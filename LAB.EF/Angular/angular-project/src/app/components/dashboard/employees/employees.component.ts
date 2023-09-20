import {AfterViewInit, Component, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatTableDataSource, MatTableModule} from '@angular/material/table';

@Component({
  selector: 'app-employees',
  styleUrls: ['./employees.component.css'],
  templateUrl: './employees.component.html',
})
export class EmployeesComponent implements AfterViewInit {
  displayedColumns: string[] = ['position', 'name', 'weight', 'edit', 'delete'];
  dataSource = new MatTableDataSource<PeriodicElement>(ELEMENT_DATA);

  @ViewChild(MatPaginator) paginator!: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }
}

export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  delete: string;
  edit: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Hydrogen', weight: 1.0079, edit: '', delete: 'H',},
  {position: 2, name: 'Helium', weight: 4.0026,  edit: '', delete: 'He',},
  {position: 3, name: 'Lithium', weight: 6.941, edit: '', delete: 'H',},
  {position: 4, name: 'Beryllium', weight: 9.0122, edit: '', delete: 'H',},
  {position: 5, name: 'Boron', weight: 10.811, edit: '', delete: 'H',},
  {position: 6, name: 'Carbon', weight: 12.0107, edit: '', delete: 'H',},
  {position: 7, name: 'Nitrogen', weight: 14.0067, edit: '', delete: 'H',},
  {position: 8, name: 'Oxygen', weight: 15.9994, edit: '', delete: 'H',},
  {position: 9, name: 'Fluorine', weight: 18.9984, edit: '', delete: 'H',},
  {position: 10, name: 'Neon', weight: 20.1797, edit: '', delete: 'H',},
  {position: 11, name: 'Sodium', weight: 22.9897, edit: '', delete: 'H',},
  {position: 12, name: 'Magnesium', weight: 24.305, edit: '', delete: 'H',},
  {position: 13, name: 'Aluminum', weight: 26.9815, edit: '', delete: 'H',},
  {position: 14, name: 'Silicon', weight: 28.0855, edit: '', delete: 'H',},
  {position: 15, name: 'Phosphorus', weight: 30.9738, delete: 'P', edit: ''},
  {position: 16, name: 'Sulfur', weight: 32.065, delete: 'S', edit: ''},
  {position: 17, name: 'Chlorine', weight: 35.453, delete: 'Cl', edit: ''},
  {position: 18, name: 'Argon', weight: 39.948, delete: 'Ar', edit: ''},
  {position: 19, name: 'Potassium', weight: 39.0983, delete: 'K', edit: ''},
  {position: 20, name: 'Calcium', weight: 40.078, delete: 'Ca', edit: ''},
];