import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TrabajadorService } from '../../services/trabajador.service';
import { APIResponse } from '../../../shared/models/api-reponse.model';
import { Trabajador } from '../../models/trabajador.model';

@Component({
  selector: 'app-principal',
  templateUrl: './principal.component.html',
  styleUrls: ['./principal.component.css']
})
export class PrincipalComponent implements OnInit {
  

  
  @Input() trabajador :Trabajador;
  constructor() {

  }

  ngOnInit(): void {
    
   
  
  }

 
}
  

