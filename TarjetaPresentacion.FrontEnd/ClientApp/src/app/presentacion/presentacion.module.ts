import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { PrincipalComponent } from "./components/principal/principal.component";
import { PresentacionRoutingModule } from "./presentacion-routing.module";
import { SharedPresentacionModule } from './shared/shared.module';
import { DatosComponent } from './components/datos/datos.component';
import { GuardarComponent } from './components/guardar/guardar.component';
import { LocalizacionComponent } from './components/localizacion/localizacion.component';
import { QrtarjetaComponent } from './components/qrtarjeta/qrtarjeta.component';
import { VideoComponent } from "./components/video/video.component";
import { CommonModule } from "@angular/common";
import { TrabajadorService } from "./services/trabajador.service";
import { BusinessCardComponent } from './components/business-card/business-card.component';
import { CompartirComponent } from "./components/compartir/compartir.component";
import { PublicacionesComponent } from "./components/publicaciones/publicaciones.component";


const components = [PrincipalComponent,
   BusinessCardComponent  ,
   VideoComponent ,
   DatosComponent ,
   GuardarComponent ,
   LocalizacionComponent ,
   QrtarjetaComponent,
   CompartirComponent,
   PublicacionesComponent ];
   
const pipes = [];
const validators = [];
const directives = [];

@NgModule({
  declarations: [
    
    components,
        
  ],
  imports: [
    RouterModule,
    CommonModule,
    SharedPresentacionModule,
    PresentacionRoutingModule

  ],
  providers: [TrabajadorService],
  bootstrap: []
})
export class PresentacionModule { }
