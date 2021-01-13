import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { usuario } from './models/usuario';
import { AuthenticationService } from './services/authentication.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  currentUser: usuario;
  //title = 'Angular';
  constructor(
    private router: Router,
    private authenticationService: AuthenticationService
  ){
    this.authenticationService.currentUser.subscribe(x=> this.currentUser = x);
  }

  logout(): void{
    this.authenticationService.logout();
    this.router.navigate(['/Login']);
  }
}
