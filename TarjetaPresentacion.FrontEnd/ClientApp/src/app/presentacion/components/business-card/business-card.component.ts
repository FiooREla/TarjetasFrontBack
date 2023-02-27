import { Component, OnInit } from '@angular/core';
import { Trabajador } from '../../models/trabajador.model';
import { TrabajadorService } from '../../services/trabajador.service';
import { ActivatedRoute, Routes } from '@angular/router';
import { APIResponse } from '../../../shared/models/api-reponse.model';
import {Router} from "@angular/router"

export enum ContenidoAMostrar {

  Principal =0,
  Compartir =1,
  Datos =2,
  Guardar =3,
  Localziacion =4,
  Publicaciones =5,
  QRTarjeta =6,
  Video = 7,

}

@Component({
  selector: 'app-business-card',
  templateUrl: './business-card.component.html',
  styleUrls: ['./business-card.component.css']
})



export class BusinessCardComponent implements OnInit {

   public contenido :ContenidoAMostrar = ContenidoAMostrar.Principal;
   public trabajador : Trabajador;
   public mostrarTextoIconos : boolean = false;
   public id : string;

   
   constructor( private route : ActivatedRoute, 
               private trabajadorService : TrabajadorService,
               private router : Router ) {
   
                this.id =  this.route.snapshot.params["id"] ;
                console.log('this.id', this.id);
   }
  ngOnInit(): void {
    
    this.findId();

  }

  findId(){

    if (this.id) {

        this.trabajadorService.findByID(this.id).subscribe((response : APIResponse)=> {


          this.trabajador = response.valorObjeto as Trabajador;

          console.log('this.trabajador', this.trabajador);

        }, (error:APIResponse)=> {
            try {


              console.log('error', error);

              if(error.codigo ==500){

                this.router.navigate(['./500']);//error interno de servidor o no conecta a la api

              }
              else if(error.codigo ==404) {
  
                  this.router.navigate(['./404']);
              }
             
              else {
                console.log('else error', error);

              }
              
            } catch (error) {

              console.log('catch error', error);

            }
            
            
        } )
    }

  }


   cambiarContenidoAMostrar( contenidoAMostrar :ContenidoAMostrar ){

      this.contenido = contenidoAMostrar;

   }

   ocultarTexto(){


   }
   mostrarTexto(){

   }

}
