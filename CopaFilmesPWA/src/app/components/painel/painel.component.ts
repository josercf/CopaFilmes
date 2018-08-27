import { Component, OnInit, Output } from '@angular/core';
import { GridSelecaoServico } from '../../services/gridSelecaoServico';
import { EventEmitter } from 'events';
import { CopaFilmeServico } from '../../services/copaFilmeServico';

@Component({
  selector: 'app-painel',
  templateUrl: './painel.component.html',
  styleUrls: ['./painel.component.css']
})
export class PainelComponent implements OnInit {

  @Output()
  public gerarCampeonatoEvent = new EventEmitter();

  constructor(private servico: GridSelecaoServico) { }

  ngOnInit() {
    this.servico.qtdeSelecionados.subscribe(qtde => this.quantidadeSelecionado = qtde);
  }


  quantidadeSelecionado: number = 0;

  gerarCampeonato() {
    this.gerarCampeonatoEvent.emit(null);
  }

}
