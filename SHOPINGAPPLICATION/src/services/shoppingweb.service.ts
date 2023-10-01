import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class ShoppingWebService{
    constructor (private httpClient:HttpClient){

    }
    ProductList(){
        return this.httpClient.get("http://localhost:5042/api/Product");
    }


}