import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-miperfil',
  templateUrl: './miperfil.component.html',
  styleUrls: ['./miperfil.component.css']
})
export class MiperfilComponent implements OnInit {
  nombre: string;
  apellido: string;
  dni: Number;
  localidad: string;
  direccion: string;
  email: string;
  ncelular: Number;

  constructor() { }

  ngOnInit(): void {
  }

}
