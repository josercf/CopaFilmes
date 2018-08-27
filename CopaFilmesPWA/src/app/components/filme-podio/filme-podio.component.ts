import { Component, OnInit, Input } from '@angular/core';
import { Partida } from '../../model/partida';

@Component({
  selector: 'app-filme-podio',
  templateUrl: './filme-podio.component.html',
  styleUrls: ['./filme-podio.component.css']
})
export class FilmePodioComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  @Input()
  public resultadoFinal: Partida;

}
