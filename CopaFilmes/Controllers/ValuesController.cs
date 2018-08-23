using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaFilmes.Dominio.Contratos;
using CopaFilmes.Dominio.Entidades;
using CopaFilmes.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace CopaFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IFilmeService filmeService;

        public ValuesController(IFilmeService filmeService)
        {
            this.filmeService = filmeService;
        }
        // GET api/values
        [HttpGet]
        public  IActionResult Get()
        {
            //var data = await filmeService.Listar();

            var data = filmeService.ProcessarFases(FimesServicoMock.ObterSelecao());
            return Ok(data);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
