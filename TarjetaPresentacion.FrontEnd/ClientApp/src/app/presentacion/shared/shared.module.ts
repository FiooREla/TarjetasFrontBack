import { NgModule } from "@angular/core";
import { FooterComponent } from "./footer/footer.component";
import { NavbarComponent } from './navbar/navbar.component';

const components = [FooterComponent , NavbarComponent];
const pipes = [];
const validators = [];
const directives = [];

@NgModule({
  declarations: [
    components
  ],
  imports: [
   
  ],
  exports : [components],
  
  providers: [],
  bootstrap: []
})
export class SharedPresentacionModule { }
