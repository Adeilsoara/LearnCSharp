using ConectarBancoPostgre.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConectarBancoPostgre.Controllers {
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DadosController : ControllerBase {
        private readonly IDadosRepository _repository;

        public DadosController(IDadosRepository repository) {
            _repository = repository;
        }

        [HttpGet]
        [Route("dados")]
        public async Task<IActionResult> GetDadosAll() {
            var result = await _repository.GetDadosAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("dado")]
        public async Task<IActionResult> GetDados(int gId) {
            var result = await _repository.GetDados(gId);
            return Ok(result);
        }
    }
}
