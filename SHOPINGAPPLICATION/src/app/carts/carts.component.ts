import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Cartsservice } from 'src/services/cart.service';
import { ShoppingWebService } from 'src/services/shoppingweb.service';

@Component({
  selector: 'app-carts',
  templateUrl: './carts.component.html',
  styleUrls: ['./carts.component.css']
})
export class CartsComponent {
  resultdata1:any;
  constructor(private cartsservice:Cartsservice,private router:Router){
    this.cartsservice.CartsList().subscribe(data=>{
      console.log(data);
      this.resultdata1=data;
    })
  }
}
