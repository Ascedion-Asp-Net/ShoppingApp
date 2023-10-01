import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { FormsModule } from '@angular/forms';
import{HttpClientModule}from '@angular/common/http';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductComponent } from './product/product.component';
import { OrderComponent } from './order/order.component';
import { UserComponent } from './user/user.component';
import { ShoppingWebService } from 'src/services/shoppingweb.service';

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    OrderComponent,
    UserComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
    
  ],
  providers: [ShoppingWebService],
  bootstrap: [AppComponent]
})
export class AppModule { }
