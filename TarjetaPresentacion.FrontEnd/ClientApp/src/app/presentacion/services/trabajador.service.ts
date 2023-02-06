import { Injectable } from "@angular/core";
import { RepositoryService } from "src/app/core/services/repository.service";
import { HttpParams } from '@angular/common/http';

@Injectable()
export class TrabajadorService {

    private construirRuta(ruta: string): string {
        return `api/Trabajador/${ruta}`;
    }
    constructor( private repository: RepositoryService) {
      
        
    }

    public  getAll() {
        return this.repository.getData(this.construirRuta(`getAll`));  
    }

    public  findByID(id : string) {

        let parametros = new HttpParams().append("id",id);
        return this.repository.getData(this.construirRuta(`findByID`),parametros); 
    }

}