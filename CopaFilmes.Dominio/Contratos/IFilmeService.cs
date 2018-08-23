using CopaFilmes.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaFilmes.Dominio.Contratos
{
    public interface IFilmeService
    {
        Task<IEnumerable<Filme>> Listar();

        IEnumerable<Filme> Processar(List<Filme> filmesSelecionados, bool ordenarPorNota);

        Partida ProcessarFases(IEnumerable<Filme> filmesSelecionados);
    }
}
