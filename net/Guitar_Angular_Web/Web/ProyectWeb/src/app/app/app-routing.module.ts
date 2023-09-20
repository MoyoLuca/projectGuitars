import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


const routes: Routes = [

  { path:'', loadChildren:()=> import('../../pages/home/home-routing.module'). then((m)=>m.HomeRoutingModule)},
  { path:'contact', loadChildren:()=> import('../../pages/contact/contact-routing.module'). then((m)=>m.ContactRoutingModule)}

];

@NgModule({
  imports: [RouterModule.forRoot(routes, {useHash: false, scrollPositionRestoration: 'enabled'})],
  exports: [RouterModule]
})
export class AppRoutingModule { }

