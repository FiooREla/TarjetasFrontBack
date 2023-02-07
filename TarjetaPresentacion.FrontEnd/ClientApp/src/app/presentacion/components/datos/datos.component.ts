import { Component, Input } from '@angular/core';
import { Trabajador } from '../../models/trabajador.model';

@Component({
  selector: 'app-datos',
  templateUrl: './datos.component.html',
  styleUrls: ['./datos.component.css']
})
export class DatosComponent {

  @Input() trabajador :Trabajador;
}
