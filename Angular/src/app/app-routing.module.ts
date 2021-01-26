import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
//import { from } from 'rxjs';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/sesion/login/login.component';
import { RegisterComponent} from './components/sesion/register/register.component';

const routes: Routes = [
  {path:'',component: HomeComponent},
  {path:'login',component: LoginComponent},
  {path:'register',component: RegisterComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
