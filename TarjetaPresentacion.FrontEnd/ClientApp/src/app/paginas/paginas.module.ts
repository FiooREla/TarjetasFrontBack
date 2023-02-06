import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";

import { SharedModule } from '../shared/shared.module';
import { Pagina404Component } from "./pagina404/pagina404.component";
import { PaginasRoutingModule } from "./paginas-routing.module";

const components = [Pagina404Component ];
   
const pipes = [];
const validators = [];
const directives = [];

@NgModule({
  declarations: [
    
    components,
    
    
  ],
  imports: [
    RouterModule,
    SharedModule,
    PaginasRoutingModule
   

  ],
  providers: [],
  bootstrap: []
})
export class PaginasModule { }
