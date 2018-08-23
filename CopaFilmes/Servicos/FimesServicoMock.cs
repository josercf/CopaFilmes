using CopaFilmes.Dominio.Entidades;
using System.Collections.Generic;

namespace CopaFilmes.Servicos
{
    public class FimesServicoMock
    {
        public static IEnumerable<Filme> ObterSelecao()
        {
            return  new List<Filme>
            {
                    new Filme {
                        id = "tt3606756",
                        titulo= "Os Incríveis 2",
                        ano= 2018,
                        nota= 8.5F
                    },
                   new Filme{
                        id= "tt4881806",
                        titulo = "Jurassic World= Reino Ameaçado",
                        ano = 2018,
                        nota= 6.7F
                },
                  new Filme{
                        id= "tt5164214",
                        titulo = "Oito Mulheres e um Segredo",
                        ano = 2018,
                        nota =6.3F
                },
                   new Filme{
                        id= "tt7784604",
                        titulo = "Hereditário",
                        ano = 2018,
                        nota =7.8F
                },
                   new Filme{
                        id= "tt4154756",
                        titulo = "Vingadores= Guerra Infinita",
                        ano = 2018,
                        nota=8.8F
                },
                 new Filme{
                        id= "tt5463162",
                        titulo = "Deadpool 2",
                        ano = 2018,
                        nota =8.1F
                },
                  new Filme{
                        id= "tt3778644",
                        titulo = "Han Solo= Uma História Star Wars",
                        ano = 2018,
                        nota= 7.2F
                },
                 new Filme{
                        id= "tt3501632",
                        titulo = "Thor= Ragnarok",
                        ano = 2017,
                        nota= 7.9F
                }
            };
        }
    }
}
