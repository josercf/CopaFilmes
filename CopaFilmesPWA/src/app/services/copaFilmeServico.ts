import { Filme } from "../model/filme";
import { Partida } from "../model/partida";

import { Observable } from "rxjs";
import { Injectable } from "@angular/core";
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from "../../environments/environment";

@Injectable()
export class CopaFilmeServico {

    filmesUrl = `${environment.apiUrl}api/Filmes/`;

    constructor(private http: HttpClient) { }

    public obterFilmes(): Observable<Filme[]> {
        return this.http.get<Filme[]>(this.filmesUrl);
    }

    public obterFinalistas(filmesParticipantes: Filme[]): Observable<Partida> {
        return this.http.post<Partida>(this.filmesUrl, filmesParticipantes);
    }
}