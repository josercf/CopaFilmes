import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { GridSelecaoServico } from '../../services/gridSelecaoServico';

@Component({
  selector: 'app-painel',
  templateUrl: './painel.component.html',
  styleUrls: ['./painel.component.css']
})
export class PainelComponent implements OnInit {

  @Output() OnGerarCampeonato = new EventEmitter();

  constructor(private servico: GridSelecaoServico) { }

  ngOnInit() {
    this.servico.qtdeSelecionados.subscribe(qtde => this.quantidadeSelecionado = qtde);
  }


  quantidadeSelecionado: number = 0;

  gerarCampeonato() {
    this.OnGerarCampeonato.emit(null);
  }

}
