using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Picoletes.Core.Interfaces;
using Picoletes.Core.Models;

namespace Picoletes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstoqueController : ControllerBase
    {
        private readonly IEstoqueRepository _repo;
        public EstoqueController(IEstoqueRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Estoque>>> GetEstoque()
        {
            var estoque = await _repo.GetEstoqueAsync();
            return Ok(estoque);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Estoque>> GetEstoqueById(int id)
        {
            return await _repo.GetEstoqueByIdAsync(id);
        }
    }
}
