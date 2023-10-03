import { HttpClient } from "@angular/common/http"
import { Injectable } from "@angular/core"
import { User } from "src/app/login/user"

@Injectable()
export class UserService{
    constructor(private httpClient:HttpClient){}

    login(user:User){
        return this.httpClient.post("http://localhost:5042/api/User/Login",user)
    }

    sighup(user:User){
        return this.httpClient.post("http://localhost:5042/api/User/Register",user)
    }
}