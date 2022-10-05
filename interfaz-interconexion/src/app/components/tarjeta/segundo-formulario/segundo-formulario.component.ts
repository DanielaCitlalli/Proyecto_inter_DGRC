import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-segundo-formulario',
  templateUrl: './segundo-formulario.component.html',
  styleUrls: ['./segundo-formulario.component.css']
})
export class SegundoFormularioComponent implements OnInit {

  @Input()verSegundoFormulario: boolean = false;

  constructor() { }

  ngOnInit(): void {
    console.log(this.verSegundoFormulario);
    
  }

}
