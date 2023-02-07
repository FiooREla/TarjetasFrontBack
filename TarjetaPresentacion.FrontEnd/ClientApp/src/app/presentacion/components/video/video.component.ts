import { Component, Input } from '@angular/core';
import { Trabajador } from '../../models/trabajador.model';
@Component({
  selector: 'app-video',
  templateUrl: './video.component.html',
  styleUrls: ['./video.component.css']
})
export class VideoComponent {
  @Input() trabajador :Trabajador;
}
