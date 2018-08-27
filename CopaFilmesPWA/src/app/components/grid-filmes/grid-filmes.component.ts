import { Component, OnInit, Input } from '@angular/core';
import { Filme } from '../../model/filme';

@Component({
    selector: 'app-grid-filmes',
    templateUrl: './grid-filmes.component.html',
    styleUrls: ['./grid-filmes.component.css']
})
export class GridFilmesComponent implements OnInit {

    constructor() {

        let cols: number = 4;
        let rows: number = 1;
    }

    ngOnInit() {
    }

    @Input()
    filmes: Filme[] = [];

}
