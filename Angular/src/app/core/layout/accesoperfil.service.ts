import { Injectable } from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AccesoperfilService {
  readonly rootURL = "https://localhost:44357/api";
  constructor(private http: HttpClient) { }

  GetAutehnticate(idUsuario: string, contrasena: string):Observable<any[]>{
      let options = new HttpParams();
      options = options.append('idUsuario', idUsuario);
      options = options.append('contrasena', contrasena);
      return this.http.get<any[]>(this.rootURL+'/Login', {params:options});
    }
}
