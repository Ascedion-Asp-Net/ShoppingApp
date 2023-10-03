import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductComponent } from './product/product.component';
import { LoginComponent } from './login/login.component';
import { MenuComponent } from './menu/menu.component';
import { RegisterComponent } from './register/register.component';
import { CartsComponent } from './carts/carts.component';

const routes: Routes = [
  {
  path:'product',
  component:ProductComponent
  },
 
   { path: '', component: LoginComponent },
   { path: 'menu', component: MenuComponent },
   { path: 'register', component: RegisterComponent },
   { path: 'carts', component: CartsComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
