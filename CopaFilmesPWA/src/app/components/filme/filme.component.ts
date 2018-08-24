import { Component, OnInit, Input } from '@angular/core';
import { Filme } from '../../model/filme';

@Component({
  selector: 'app-filme',
  templateUrl: './filme.component.html',
  styleUrls: ['./filme.component.css']
})
export class FilmeComponent implements OnInit {

  constructor() {
    this.filme = new Filme();
   }

  ngOnInit() {
  }

  @Input()
  public filme: Filme;
  checked: boolean;

}
