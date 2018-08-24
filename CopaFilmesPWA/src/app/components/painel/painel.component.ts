import { Component, OnInit } from '@angular/core';
import { GridSelecaoServico } from '../../services/gridSelecaoServico';

@Component({
  selector: 'app-painel',
  templateUrl: './painel.component.html',
  styleUrls: ['./painel.component.css']
})
export class PainelComponent implements OnInit {

  constructor(private servico: GridSelecaoServico) { }

  ngOnInit() {
    this.servico.qtdeSelecionados.subscribe(qtde => this.quantidadeSelecionado = qtde);
  }

  quantidadeSelecionado: number = 0;

}
