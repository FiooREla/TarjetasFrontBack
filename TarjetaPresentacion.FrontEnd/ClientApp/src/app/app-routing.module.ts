import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


const routes: Routes = [
  {
    path:'',
    loadChildren: () => import("./presentacion/presentacion.module").then(m=>m.PresentacionModule)
  },
  { 
    path: '**', 
    pathMatch: 'full', 
    redirectTo: '404'
  }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
