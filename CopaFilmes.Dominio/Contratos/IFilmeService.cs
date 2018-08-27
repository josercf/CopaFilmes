using CopaFilmes.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaFilmes.Dominio.Contratos
{
    public interface IFilmeService
    {
        Task<IEnumerable<Filme>> ListarAsync();

        IEnumerable<Filme> Processar(List<Filme> filmesSelecionados, bool ordenarPorNota);

        Partida ProcessarFases(IEnumerable<Filme> filmesSelecionados);
    }
}
