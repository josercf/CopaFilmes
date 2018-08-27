using CopaFilmes.Dominio.Contratos;
using CopaFilmes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CopaFilmes.Servicos
{
    public class CopaFilmesServico : IFilmeService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private const string FILMES_ENDPOINT = "/api/filmes";

        public CopaFilmesServico(IHttpClientFactory httpClientFactory)
            => _httpClientFactory = httpClientFactory;

        /// <summary>
        /// Recuperar catálogo de filmes
        /// a partir de uma api externa
        /// </summary>
        /// <returns>IEnumerable<Filme></returns>
        public async Task<IEnumerable<Filme>> ListarAsync()
        {
            var client = _httpClientFactory.CreateClient("filmeSource");
            var response = await client.GetAsync(FILMES_ENDPOINT);
            response.EnsureSuccessStatusCode();
            var catalago = await response.Content.ReadAsAsync<List<Filme>>();

            return catalago;
        }

        /// <summary>
        /// Processa todas as fases do campeonato a partir
        /// de uma lista de  filmes
        /// </summary>
        /// <param name="filmesSelecionados"></param>
        /// <returns>Retorna o campeão e o vice após executar todas as fases</returns>
        public Partida ProcessarFases(IEnumerable<Filme> filmesSelecionados)
        {
            var finalistas = Processar(filmesSelecionados.ToList(), false);
            return new Partida(finalistas.First(), finalistas.Last());
        }

        /// <summary>
        /// Processa todas as fases do campeonato
        /// </summary>
        /// <param name="filmesSelecionados"></param>
        /// <param name="ordenarPorNota">Após a primeira rodada, deverá ser realizada 
        /// ordenação por nota</param>
        /// <returns>Lista com os filmes finalistas</returns>
        public IEnumerable<Filme> Processar(List<Filme> filmesSelecionados, bool ordenarPorNota)
        {
            var chave = new List<Filme>();

            if(ordenarPorNota)
                filmesSelecionados.Sort((a, b) => a.nota.CompareTo(b.nota));

            var total = filmesSelecionados.Count() / 2;

            for (int i = 0; i < total; i++)
            {
                Filme vencedor = ExecutarPartida(filmesSelecionados, i);
                chave.Add(vencedor);
            }

            if (chave.Count == 2)
                return chave;

            return Processar(chave, true);
        }

        private Filme ExecutarPartida(List<Filme> filmesSelecionados, int i)
        {
            var primeiro = filmesSelecionados.ElementAt(i);
            var ultimo = filmesSelecionados.ElementAt(filmesSelecionados.Count() - (i + 1));

            var partida = new Partida(primeiro, ultimo);
            var vencedor = partida.ExecutarDisputa();
            return vencedor;
        }

        private void OrdenarCatalago(List<Filme> catalago)
                => catalago.Sort((a, b) => a.titulo.CompareTo(b.titulo));
    }
}
