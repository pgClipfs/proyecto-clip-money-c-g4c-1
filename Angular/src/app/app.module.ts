import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { RouterModule, Routes } from '@angular/router';

import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavbarComponent } from './components/navbar/navbar.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { LoginComponent } from './components/sesion/login/login.component';
import { RegisterComponent } from './components/sesion/register/register.component';
import { RecuperarPssComponent } from './components/sesion/recuperar-pss/recuperar-pss.component';
import { AccesoperfilService } from './core/layout/accesoperfil.service';

const appRoutes: Routes=[
  {path: 'login', component:LoginComponent},
  {path: 'register', component:RegisterComponent},
  {path: 'recuperacionPss', component:RecuperarPssComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    LoginComponent,
    RegisterComponent,
    RecuperarPssComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(appRoutes),
    MatToolbarModule,
    HttpClientModule
  ],
  providers: [AccesoperfilService],
  bootstrap: [AppComponent]
})
export class AppModule { }
