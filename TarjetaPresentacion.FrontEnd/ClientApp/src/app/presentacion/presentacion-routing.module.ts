import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BusinessCardComponent } from './components/business-card/business-card.component';


const routes: Routes = [

  /* { path: '', redirectTo : 'bcard'}, */
  { path: 'bcard/:id', component: BusinessCardComponent},
  ];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PresentacionRoutingModule { }
