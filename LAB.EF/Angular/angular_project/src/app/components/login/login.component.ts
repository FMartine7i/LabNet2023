import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar, MatSnackBarRef, MatSnackBarModule } from '@angular/material/snack-bar';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  hide:boolean = true;
  loading:boolean = false;

  formLogin:FormGroup;

  constructor( private fb:FormBuilder, private _snackBar: MatSnackBar, private router:Router){
    this.formLogin = this.fb.group({
      user_name: ['', Validators.required],
      password: ['', Validators.required]
    })
  }

  login() {
    this.router.navigate(['dashboard/layout']); 
  }

  login_account(){
    console.log(this.formLogin);

    const user_name = this.formLogin.value.user_name;
    const password = this.formLogin.value.password;

    if(user_name == 'admin' && password == '123'){
      this.fake_redirection()
    }
    else{
      this.errorMessage();
    }
  }

  fake_redirection(){
    this.loading = true;
    setTimeout(() => {
      this.loading = false
      this.router.navigate(['dashboard/layout'])
    }, 2000)
  }

  errorMessage() {
    this._snackBar.open('Usuario o contraseña inválidos', 'OK', {
      duration: 3000,
      horizontalPosition: "center",
      verticalPosition: "bottom"
      });
    }
  }

