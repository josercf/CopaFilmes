using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Dominio.Entidades
{
    public class Partida
    {
        public Partida(Filme primeiro, Filme segundo)
        {
            Primeiro = primeiro;
            Segundo = segundo;
        }

        public Partida(IEnumerable<Filme> filmes)
            : this(filmes.First(), filmes.Last())
        { }

        public Filme Primeiro { get; private set; }
        public Filme Segundo { get; private set; }

        public virtual Filme ExecutarDisputa()
        {
            if(Primeiro.nota == Segundo.nota)
            {
                var list = new List<Filme> { Primeiro, Segundo };
                list.Sort((atual, proximo) => atual.titulo.CompareTo(proximo.titulo));

                return list.First();
            }

            if (Segundo.nota > Primeiro.nota)
                return Segundo;

            return Primeiro;
        }

    }
}
