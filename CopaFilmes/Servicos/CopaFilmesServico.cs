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
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<Filme>> Listar()
        {
            var client = _httpClientFactory.CreateClient("filmeSource");
            var response = await client.GetAsync(FILMES_ENDPOINT);
            response.EnsureSuccessStatusCode();
            var catalago = await response.Content.ReadAsAsync<List<Filme>>();

            return OrdenarCatalago(catalago);
        }

        private IEnumerable<Filme> OrdenarCatalago(IEnumerable<Filme> catalago)
                => catalago.OrderBy(c => c.titulo);

        public IEnumerable<Filme> Processar(IEnumerable<Filme> filmesSelecionados)
        {
            var chave = new List<Filme>();
            var total = filmesSelecionados.Count() / 2;

            for (int i = 0; i < total; i++)
            {
                var primeiro = filmesSelecionados.ElementAt(i);
                var indiceUltimo = filmesSelecionados.Count() - (i + 1);
                var ultimo = filmesSelecionados.ElementAt(indiceUltimo);

                var itens = OrdenarCatalago(new List<Filme> { primeiro, ultimo });

                var partida = new Partida(primeiro, ultimo);
                var vencedor = partida.ExecutarDisputa();
                chave.Add(vencedor);
            }

            if (chave.Count == 2)
                return OrdenarCatalago(chave);

            return Processar(chave);
        }

        public Partida ProcessarFases(IEnumerable<Filme> filmesSelecionados)
        {
            var finalistas = Processar(OrdenarCatalago(filmesSelecionados));
            return new Partida(finalistas.First(), finalistas.Last());
        }
    }
}
