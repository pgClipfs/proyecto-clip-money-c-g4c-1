import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
//import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavbarComponent } from './components/navbar/navbar.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { LoginComponent } from './components/sesion/login/login.component';
import { HomeComponent } from './components/home/home.component';
import { InicioComponent } from './components/inicio/inicio.component';
import { IndexOperacionesComponent } from './components/operaciones/index-operaciones/index-operaciones.component';
import { IndexComponent } from './components/index/index.component';
import { GuardService } from './services/guard.service';
import { CuentasComponent } from './components/cuentas/cuentas.component';
import { DetalleCuentaComponent } from './components/cuentas/detalle-cuenta/detalle-cuenta.component';
import { MovimientosComponent } from './components/cuentas/detalle-cuenta/movimientos/movimientos.component';
import { ClienteComponent } from './components/cliente/cliente.component';
import { ModificarComponent } from './components/cliente/modificar/modificar.component';
import { ObtenerComponent } from './components/cliente/obtener/obtener.component';
import { RecoveryMailComponent } from './components/recoverymail/recoverymail.component';
import { RecoverypasswordComponent } from './components/recoverypassword/recoverypassword.component';
import { AppRoutingModule } from './app-routing.module';




const routes: Routes =
[
  {path: '', component: IndexComponent},
  {path: 'index', component: IndexComponent},
  {path: 'login', component: LoginComponent},
  {path: 'home', component: HomeComponent},
  {path: 'inicio', component: InicioComponent},
  {path: 'operaciones',component:IndexOperacionesComponent},
  {path: 'cuentas', component: CuentasComponent},
  {path: 'cuentas/detalle-cuenta', component: DetalleCuentaComponent},
  {path: 'cuentas/detalle-cuenta/movimientos', component: MovimientosComponent},
  {path: 'cliente', component: ClienteComponent},
  {path: 'modificar', component: ModificarComponent, canActivate:[GuardService]},
  {path: 'obtener', component: ObtenerComponent, canActivate:[GuardService]},
  {path: 'recoverymail', component: RecoveryMailComponent},
  {path: 'recoverypassword', component: RecoverypasswordComponent},
  {path: '**', component: IndexComponent},
];

@NgModule({
  declarations: [
    AppComponent,
    ClienteComponent,
    HomeComponent,
    NavbarComponent,
    IndexComponent,
    InicioComponent,
    LoginComponent,
    RecoveryMailComponent,
    RecoverypasswordComponent,
    ModificarComponent,
    ObtenerComponent,
    IndexOperacionesComponent,
    CuentasComponent,
    DetalleCuentaComponent,
    MovimientosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserModule,
    FormsModule, 
    ReactiveFormsModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(routes),
    MatToolbarModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
