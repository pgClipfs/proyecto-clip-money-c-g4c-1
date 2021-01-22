import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import {UsuarioService} from '../../../services/usuario.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  formGroup: FormGroup;
  
  constructor(
    private fb:FormBuilder,
    private usuario:UsuarioService,
  ) { }
  form(){
    this.formGroup=this.fb.group({
      username:[""],
      password:[""],
    
     });
  }
  ngOnInit(): void {
    this.form();
  }

  onSubmit(){
    const login = this.formGroup.value;
    console.log(login);
    console.log(this.formGroup)
    this.usuario.postUsuario(login).subscribe(Body => console.log(Body));
    
    
  }
}

