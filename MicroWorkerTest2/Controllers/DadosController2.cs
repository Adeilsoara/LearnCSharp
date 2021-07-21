using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MicroWorkerTest2.Entities;
using MicroWorkerTest2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroWorkerTest2.Controllers {
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DadosController2 : ControllerBase {

        private readonly IDadosRepository2 _repository;

        public DadosController2(IDadosRepository2 repository) {
            _repository = repository;
        }

      
        [HttpPost]
        public async Task<ActionResult<Dados2>> CreateDados([FromBody] Dados2 dados) {
            await _repository.CreateDados(dados);
            //return CreatedAtRoute("GetDados", new { dadosGId = dados.GId }, dados);
            return Ok(dados);
        }
    }
}
