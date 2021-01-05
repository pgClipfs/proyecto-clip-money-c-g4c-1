import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { RouterModule, Routes } from '@angular/router';

//import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavbarComponent } from './components/navbar/navbar.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { LoginComponent } from './components/sesion/login/login.component';
import { RegisterComponent } from './components/sesion/register/register.component';
import { RecuperarPssComponent } from './components/sesion/recuperar-pss/recuperar-pss.component';
import { DashboardComponent } from './components/Dashboard/Dashboard.component';
import { HomeComponent } from './components/home/home.component';
import { InicioComponent } from './components/inicio/inicio.component';
import { IndexOperacionesComponent } from './components/operaciones/index-operaciones/index-operaciones.component';

const appRoutes: Routes=[
  {path: 'login', component:LoginComponent},
  {path: 'register', component:RegisterComponent},
  {path: 'recuperacionPss', component:RecuperarPssComponent},
  {path: 'Dashboard', component:DashboardComponent},
  {path: 'home', component: HomeComponent},
  {path: 'inicio', component: InicioComponent},
  {path: 'operaciones',component:IndexOperacionesComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    LoginComponent,
    RegisterComponent,
    RecuperarPssComponent,
    DashboardComponent,
    HomeComponent,
    InicioComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(appRoutes),
    MatToolbarModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
