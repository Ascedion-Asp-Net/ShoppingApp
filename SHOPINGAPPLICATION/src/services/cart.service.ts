import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class Cartsservice{
    constructor (private httpClient:HttpClient){

    }
    CartsList(){
        return this.httpClient.get("http://localhost:5042/api/Carts");
    }


}