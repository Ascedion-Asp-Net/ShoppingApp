import { Component } from '@angular/core';
import { Product } from './Product';
import { ShoppingWebService } from 'src/services/shoppingweb.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  product:Product[]=[];
  constructor(private prductservice:ShoppingWebService,private router:Router){
    this.prductservice.ProductList().subscribe(data=>{
      console.log(data);
      this.product=data as Product[];
    })
  }
  showData(data:any)
  {
  console.log(data);
  this.router.navigate(["updatelocation" , data])
  }

}
