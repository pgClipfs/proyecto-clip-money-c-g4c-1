import { Component, OnInit } from '@angular/core';
import { AccesoperfilService } from 'src/app/core/layout/accesoperfil.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  accesoPerfil=[];

  constructor(private service: AccesoperfilService) { }

  ngOnInit(){
    this.service.GetAutehnticate("1", "123456").subscribe(data=>this.accesoPerfil=data);
  }
  onDataMenu(){
    console.log(this.accesoPerfil);
  }
}
