import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class LoginService {


  constructor(private http: HttpClient) { }

  login(user: any): Observable<any>{
    return this.http.post("https://localhost:44342/api/usuario", user);
  }
}
