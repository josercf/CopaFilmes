using CopaFilmes.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaFilmes.Dominio.Contratos
{
    public interface IFilmeService
    {
        Task<IEnumerable<Filme>> Listar();

        IEnumerable<Filme> Processar(IEnumerable<Filme> filmesSelecionados);

        Partida ProcessarFases(IEnumerable<Filme> filmesSelecionados);
    }
}
