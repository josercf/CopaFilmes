import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ServiceWorkerModule } from '@angular/service-worker';
import { environment } from '../environments/environment';
import { SelecaoPageComponent } from './pages/selecao-page/selecao-page.component';
import { CabecalhoComponent } from './components/cabecalho/cabecalho.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { 
  MatButtonModule, 
  MatCardModule, 
  MatMenuModule, 
  MatToolbarModule, 
  MatIconModule, 
  MatCheckboxModule, 
  MatGridListModule,
  MatDividerModule,
 } from '@angular/material';
import { GridFilmesComponent } from './components/grid-filmes/grid-filmes.component';
import { FilmeComponent } from './components/filme/filme.component';
import { PainelComponent } from './components/painel/painel.component';
import { GridSelecaoServico } from './services/gridSelecaoServico';
import { FilmePodioComponent } from './components/filme-podio/filme-podio.component';

@NgModule({
  declarations: [
    AppComponent,
    SelecaoPageComponent,
    CabecalhoComponent,
    GridFilmesComponent,
    FilmeComponent,
    PainelComponent,
    FilmePodioComponent
  ],
  imports: [
    BrowserModule,
    ServiceWorkerModule.register('ngsw-worker.js', { enabled: environment.production }),
    BrowserAnimationsModule,
    MatButtonModule, 
    MatCardModule, 
    MatMenuModule, 
    MatToolbarModule, 
    MatIconModule,
    MatCheckboxModule,
    MatGridListModule,
    MatDividerModule,
    MatToolbarModule
  ],
  providers:[GridSelecaoServico],
  bootstrap: [AppComponent]
})
export class AppModule { }
