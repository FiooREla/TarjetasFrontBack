import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Pagina404Component } from './pagina404/pagina404.component';


const routes: Routes = [

  { path: '', redirectTo: '404' , pathMatch : 'full'}, 
  
  { path: '404', component: Pagina404Component},
  // Internal >Server error

  { path: '500', component: Pagina404Component},
  // en construccion
  { path: 'under-construction', component: Pagina404Component},


  ];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PaginasRoutingModule { }
