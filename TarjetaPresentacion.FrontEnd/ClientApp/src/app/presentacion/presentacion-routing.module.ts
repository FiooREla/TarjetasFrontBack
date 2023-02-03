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
      { path: '', redirectTo: 'presentacion', pathMatch: 'full' },
      { path: 'presentacion', component: CuerpoComponent },
        
    ]
    
  },
  { path: '', component: CompartirComponent,
  children: [
    { path: '', redirectTo: 'compartir/:id', pathMatch: 'full' },
    { path: 'compartir', component: CompartirComponent },
      
  ]
  
  },
  { path: '', component: DatosComponent,
  children: [
    { path: '', redirectTo: 'datos/:id', pathMatch: 'full' },
    { path: 'datos', component: DatosComponent },
      
  ]
  
  },
  { path: '', component: GuardarComponent,
  children: [
    { path: '', redirectTo: 'guardar/:id', pathMatch: 'full' },
    { path: 'guardar', component: GuardarComponent },
      
  ]
  
  },
  { path: '', component: LocalizacionComponent,
  children: [
    { path: '', redirectTo: 'localizar', pathMatch: 'full' },
    { path: 'localizar', component: LocalizacionComponent },
      
  ]
  
  },
  { path: '', component: QrtarjetaComponent,
  children: [
    { path: '', redirectTo: 'qr/:id', pathMatch: 'full' },
    { path: 'qr', component: QrtarjetaComponent },
      
  ]
  
  },
  { path: '', component: VideoComponent,
  children: [
    { path: '', redirectTo: 'video', pathMatch: 'full' },
    { path: 'video', component: VideoComponent },
      
  ]
  
  },
  { path: '', component: PublicacionesComponent,
  children: [
    { path: '', redirectTo: 'video/:id', pathMatch: 'full' },
    { path: 'video', component: PublicacionesComponent },
      
  ]
  
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PresentacionRoutingModule { }
