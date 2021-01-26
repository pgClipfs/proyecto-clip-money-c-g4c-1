import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders}from '@angular/common/http';
import {Observable} from 'rxjs/internal/Observable';
import {LoginComponent} from '../components/sesion/login/login.component'

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  constructor(
    private httpuser:HttpClient,
  ) { }
  base='https://localhost:44386/api/login/echoping'

  base1='https://localhost:44386/api/login/authenticate'

  getUsuarioMet() :Observable<any>{
    
    return this.httpuser.get(this.base);
   
  }

  postUsuario(login: any) :Observable <any>{
    
    return this.httpuser.post(this.base1,login);
  }

}
