import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CuerpoComponent } from './components/cuerpo/cuerpo.component';
import { PrincipalComponent } from './components/principal/principal.component';
import { CompartirComponent } from './components/compartir/compartir.component';
import { DatosComponent } from './components/datos/datos.component';
import { GuardarComponent } from './components/guardar/guardar.component';
import { LocalizacionComponent } from './components/localizacion/localizacion.component';
import { QrtarjetaComponent } from './components/qrtarjeta/qrtarjeta.component';
import { VideoComponent } from './components/video/video.component';
import { PublicacionesComponent } from './components/publicaciones/publicaciones.component';


const routes: Routes = [

  { path: '', component: PrincipalComponent,
    children: [
      
      { path: 'presentacion/:id', component: CuerpoComponent },
      { path: 'compartir/:id', component: CompartirComponent },
      { path: 'video/:id', component: CompartirComponent },
      { path: 'guardar/:id', component: DatosComponent },
      { path: 'localizar/:id', component: DatosComponent },
      { path: 'qr/:id', component: DatosComponent },
        
    ]
    
  },
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PresentacionRoutingModule { }
