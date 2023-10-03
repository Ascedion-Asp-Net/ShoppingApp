import { Component } from '@angular/core';
import { User } from '../login/user';
import { UserService } from 'src/services/users.ervice';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  user:User = new User();
constructor(private userservice:UserService , private router:Router){

}
signup(){
  this.userservice.sighup(this.user).subscribe(data=>{
    this.user = data as User;
    if(this.user.username!=null){
      alert("user has been added go to the login page")
      this.router.navigateByUrl("")
    }
    else{
      alert("Sorry , unable to add at this Moment")
    }
  },
  (err)=>{
        console.log(err);
      }
  );
  this.user=new User();
}

}


