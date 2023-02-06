import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TrabajadorService } from '../../services/trabajador.service';
import { APIResponse } from '../../../shared/models/api-reponse.model';
import { Trabajador } from '../../models/trabajador.model';

@Component({
  selector: 'app-cuerpo',
  templateUrl: './cuerpo.component.html',
  styleUrls: ['./cuerpo.component.css']
})
export class CuerpoComponent implements OnInit {
  
  private id : string;
  public mostrarTextoIconos : boolean;
  private trabajador :Trabajador = new Trabajador();
  constructor(private route:ActivatedRoute,
              private trabajadorService : TrabajadorService) {

       
    this.id = this.route.snapshot.params['id'];

    

  }

  ngOnInit(): void {
    
    this.findById();
  
  }

  findById(){

     console.log('this.id',this.id);

      if(this.id){
        
        this.trabajadorService.findByID(this.id).subscribe( (resultado : APIResponse) => {
          
           this.trabajador =  resultado.valorObjeto as Trabajador;
                 
        } , (error)=> {
    
            try {
              
            } catch (error) {
              
            }
           
            
        } );
      }
      else{

      }

  }
  mostrarTexto(){ 
      
    this.mostrarTextoIconos = true;
  }
  ocultarTexto(){

    console.log("outt")
    this.mostrarTextoIconos = false;
  }
}
  

