import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { PrincipalComponent } from "./components/principal/principal.component";
import { PresentacionRoutingModule } from "./presentacion-routing.module";
import { SharedPresentacionModule } from './shared/shared.module';
import { CuerpoComponent } from './components/cuerpo/cuerpo.component';
import { DatosComponent } from './components/datos/datos.component';
import { GuardarComponent } from './components/guardar/guardar.component';
import { LocalizacionComponent } from './components/localizacion/localizacion.component';
import { QrtarjetaComponent } from './components/qrtarjeta/qrtarjeta.component';
import { VideoComponent } from "./components/video/video.component";
import { PublicacionesComponent } from './components/publicaciones/publicaciones.component';

const components = [PrincipalComponent  , VideoComponent, CuerpoComponent , DatosComponent , GuardarComponent , LocalizacionComponent ,QrtarjetaComponent ];
const pipes = [];
const validators = [];
const directives = [];

@NgModule({
  declarations: [
    
    components,
         PublicacionesComponent
  ],
  imports: [
    RouterModule,
    SharedPresentacionModule,
    PresentacionRoutingModule

  ],
  providers: [],
  bootstrap: []
})
export class PresentacionModule { }
