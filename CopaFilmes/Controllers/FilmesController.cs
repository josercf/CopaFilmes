using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CopaFilmes.Dominio.Contratos;
using CopaFilmes.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CopaFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly IFilmeService filmeService;
        public FilmesController(IFilmeService filmeService)
        {
            this.filmeService = filmeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var data = await filmeService.ListarAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest("Houve um erro ao recuperar o catálogo de filmes");
            }
        }

        [HttpPost]
        public IActionResult Post(List<Filme> filmesSelecionados)
        {
            try
            {
                var data = filmeService.ProcessarFases(filmesSelecionados);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest("Houve um erro ao processar filmes selecionados");
            }
        }
    }
}