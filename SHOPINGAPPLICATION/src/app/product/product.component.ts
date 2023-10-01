import { Component } from '@angular/core';
import { Product } from './Product';
import { ShoppingWebService } from 'src/services/shoppingweb.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  product:Product[]=[];
  constructor(private prductservice:ShoppingWebService){
    this.prductservice.ProductList().subscribe(data=>{
      console.log(data);
      this.product=data as Product[];
    })
  }

}
