import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { FormsModule } from '@angular/forms';
import{HttpClientModule}from '@angular/common/http';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductComponent } from './product/product.component';



import { ShoppingWebService } from 'src/services/shoppingweb.service';
import { LoginComponent } from './login/login.component';
import { UserService } from 'src/services/users.ervice';
import { CartsComponent } from './carts/carts.component';
import { MenuComponent } from './menu/menu.component';
import { RegisterComponent } from './register/register.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
   
    LoginComponent,
        CartsComponent,
        MenuComponent,
        RegisterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  //   FormsModule,JwtModul.forRoot({
  //     config:{
  //       tokenGetter:tokenGetter,
  //       allowedDomains:["http://localhost:5043/"]
  //     }
  // })
    
  ],
  providers: [ShoppingWebService,UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
