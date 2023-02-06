import { Component, Input } from '@angular/core';
import { Trabajador } from '../../models/trabajador.model';

@Component({
  selector: 'app-compartir',
  templateUrl: './compartir.component.html',
  styleUrls: ['./compartir.component.css']
})
export class CompartirComponent {

  @Input() trabajador :Trabajador;

}
