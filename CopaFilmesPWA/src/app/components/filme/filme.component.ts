import { Component, OnInit, Input } from '@angular/core';
import { Filme } from '../../model/filme';
import { GridSelecaoServico } from '../../services/gridSelecaoServico';
import { MatCheckboxChange } from '@angular/material/checkbox/typings/checkbox';
import { queryDef } from '@angular/core/src/view';

@Component({
  selector: 'app-filme',
  templateUrl: './filme.component.html',
  styleUrls: ['./filme.component.css']
})
export class FilmeComponent implements OnInit {

  constructor(private selecaoService: GridSelecaoServico) {
    this.filme = new Filme();
  }

  ngOnInit() {
    this.selecaoService.qtdeSelecionados.subscribe(qtde => {
      this.desabilitado = (qtde >= 8 && !this.checked);
      //console.log(`filme: ${this.filme.titulo} qtde: ${qtde} checked: ${this.checked}`);
    })
  }

  @Input()
  public filme: Filme;
  checked: boolean = false;
  desabilitado: boolean = false;

  onFilmeSelecionado(obj: MatCheckboxChange): void {
    this.checked = obj.checked;
    if (obj.checked) {
      this.selecaoService.AdicionarItem(this.filme)
    } else {
      this.selecaoService.RemoverItem(this.filme);
    }
  }

}
