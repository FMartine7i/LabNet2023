import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


// Existing imports
import { LayoutComponent } from './components/dashboard/layout/layout.component';
import { EmployeesComponent } from './components/dashboard/employees/employees.component';
import { LoginComponent } from './components/login/login.component';
import { SharedModule } from './components/shared/shared.module';


@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    LoginComponent,
    EmployeesComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    SharedModule   
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
