import { Component, Input } from '@angular/core';
import { Trabajador } from '../../models/trabajador.model';

@Component({
  selector: 'app-guardar',
  templateUrl: './guardar.component.html',
  styleUrls: ['./guardar.component.css']
})
export class GuardarComponent {

  @Input() trabajador :Trabajador;
}
