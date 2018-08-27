import { Component, OnInit } from '@angular/core';
import { CopaFilmeServico } from '../../services/copaFilmeServico';
import { Filme } from '../../model/filme';
import { GridSelecaoServico } from '../../services/gridSelecaoServico';
import { Partida } from '../../model/partida';

@Component({
  selector: 'app-selecao-page',
  templateUrl: './selecao-page.component.html',
  styleUrls: ['./selecao-page.component.css']
})
export class SelecaoPageComponent implements OnInit {

  titulo: string = "Fase de Seleção";
  instrucao: string = "Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão Gerar Meu Campeonato para proseguir.";
  catalogo: Filme[] = [];
  finalista: Partida;
  processando: boolean = true;

  color = 'primary';
  mode = 'determinate';
  value = 50;

  constructor(private filmesServico: CopaFilmeServico, private gridServico: GridSelecaoServico) { }

  ngOnInit() {
    this.filmesServico.obterFilmes()
      .subscribe(result => {
        this.catalogo = result;
        this.processando = false;
      });
  }

  public gerarCampeonato(obj: any) {
    this.processando = true;
    let filmesSelecionados = this.gridServico.filmesSelecionados;
    this.filmesServico.obterFinalistas(filmesSelecionados)
      .subscribe(r => {
        this.finalista = r;
        this.titulo = "Resultado FInal";
        this.instrucao = "Veja o resultado final do Campeonato de filmes de forma simples e rápida";
        this.processando = false;
      });
  }
}
