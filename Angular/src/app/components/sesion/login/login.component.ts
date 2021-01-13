import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  returnUrl: string;
  error = '';
  username: string;
  password: string;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private authenticationService: AuthenticationService
  ) { }

  ngOnInit(): void{
    this.returnUrl = this.route.snapshot.queryParams.returnUrl || '/';
  }

  onSubmit(): void{
    console.log("Ingerso");
    this.authenticationService.login(this.username, this.password).subscribe(
      data => {
        this.router.navigate([this.returnUrl])
      },
      error => {
        this.error = error;
      }
    );
    //this.loginService.login(usuario).subscribe(data => { console.log(data);});
  }
}
