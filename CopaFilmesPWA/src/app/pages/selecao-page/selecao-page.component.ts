import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-selecao-page',
  templateUrl: './selecao-page.component.html',
  styleUrls: ['./selecao-page.component.css']
})
export class SelecaoPageComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  titulo: string = "Fase de Seleção";
  instrucao : string = "Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão Gerar Meu Campeonato para proseguir.";

}
