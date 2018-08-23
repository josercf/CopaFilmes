using CopaFilmes.Dominio.Entidades;
using System;
using Xunit;

namespace CopaFilmes.Tests
{
    public class PartidaTest
    {
        [Fact]
        public void Primeiro_Filme_Deve_Vencer()
        {
            var filme1 = new Filme()
            {
                titulo = "Filme A",
                nota = 2
            };

            var filme2 = new Filme()
            {
                titulo = "Filme B",
                nota = 1
            };  

            var partida = new Partida(filme1, filme2);
            var resultado = partida.ExecutarDisputa();

            Assert.Equal(filme1, resultado);
        }

        [Fact]
        public void Segundo_Filme_Deve_Vencer()
        {
            var filme1 = new Filme()
            {
                titulo = "Filme A",
                nota = 1
            };

            var filme2 = new Filme()
            {
                titulo = "Filme B",
                nota = 2
            };

            var partida = new Partida(filme1, filme2);
            var resultado = partida.ExecutarDisputa();

            Assert.Equal(filme2, resultado);
        }

        [Fact]
        public void Desempate_Titulo_Filme_Um_Deve_Vencer()
        {
            var filme1 = new Filme()
            {
                titulo = "Filme A",
                nota = 1
            };

            var filme2 = new Filme()
            {
                titulo = "Filme B",
                nota = 1
            };


            var partida = new Partida(filme1, filme2);
            var resultado = partida.ExecutarDisputa();

            Assert.Equal(filme1, resultado);
        }

        [Fact]
        public void Desempate_Titulo_Filme_Dois_Deve_Vencer()
        {
            var filme1 = new Filme()
            {
                titulo = "Filme B",
                nota = 1
            };

            var filme2 = new Filme()
            {
                titulo = "Filme A",
                nota = 1
            };


            var partida = new Partida(filme1, filme2);
            var resultado = partida.ExecutarDisputa();

            Assert.Equal(filme2, resultado);
        }
    }
}
