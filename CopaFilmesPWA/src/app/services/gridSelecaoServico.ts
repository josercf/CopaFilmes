import { Injectable, EventEmitter } from "@angular/core";
import { Filme } from "../model/filme";

@Injectable()
export class GridSelecaoServico {

    filmesSelecionados: Filme[] = [];
    qtdeSelecionados = new EventEmitter<number>();

    public AdicionarItem(filme: Filme): void {
        this.filmesSelecionados.push(filme);
        this.AtualizarInscritos();
    }

    public RemoverItem(filme: Filme): void {
        this.filmesSelecionados = this.filmesSelecionados.filter(x => x !== filme);
        this.AtualizarInscritos();
    }

    public AtualizarInscritos(): void {
        this.qtdeSelecionados.next(this.filmesSelecionados.length);
    }
}