import { Component, Input } from '@angular/core';
import { Trabajador } from '../../models/trabajador.model';

@Component({
  selector: 'app-qrtarjeta',
  templateUrl: './qrtarjeta.component.html',
  styleUrls: ['./qrtarjeta.component.css']
})
export class QrtarjetaComponent {
  @Input() trabajador :Trabajador;
}
