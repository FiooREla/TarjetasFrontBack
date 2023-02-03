import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-cuerpo',
  templateUrl: './cuerpo.component.html',
  styleUrls: ['./cuerpo.component.css']
})
export class CuerpoComponent {
  
  private id : string;

  constructor(private route:ActivatedRoute) {
   
    
    this.id = this.route.snapshot.params['id'];


}
}
