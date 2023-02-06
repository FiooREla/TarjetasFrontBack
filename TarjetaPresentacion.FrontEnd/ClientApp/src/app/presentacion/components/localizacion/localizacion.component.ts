import { Component, Input } from '@angular/core';
import { Trabajador } from '../../models/trabajador.model';

@Component({
  selector: 'app-localizacion',
  templateUrl: './localizacion.component.html',
  styleUrls: ['./localizacion.component.css']
})
export class LocalizacionComponent {
  @Input() trabajador :Trabajador;
}
