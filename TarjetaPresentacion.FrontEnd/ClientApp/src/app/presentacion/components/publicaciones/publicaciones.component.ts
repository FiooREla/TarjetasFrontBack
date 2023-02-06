import { Component, Input } from '@angular/core';
import { Trabajador } from '../../models/trabajador.model';

@Component({
  selector: 'app-publicaciones',
  templateUrl: './publicaciones.component.html',
  styleUrls: ['./publicaciones.component.css']
})
export class PublicacionesComponent {

  @Input() trabajador :Trabajador;
}
