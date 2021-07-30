using BackendChallengeAlura.Models;
using BackendChallengeAlura.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BackendChallengeAlura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        [HttpPost]
        public IActionResult AddCategoria([FromBody] Categoria categoria)
        {
            _categoriaRepository.AddCategoria(categoria);
            return CreatedAtAction(nameof(GetCategoria), new { id = categoria.Id }, categoria);
        }

        [HttpGet]
        public IEnumerable<Categoria> GetCategoria()
        {
            return _categoriaRepository.GetCategoria();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetCategoria(int id)
        {
            var categoria = _categoriaRepository.GetCategoria(id);
            return Ok(categoria);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategoria(int id, [FromBody] Categoria newCategoria)
        {
            var IsUpdated = _categoriaRepository.UpdateCategoria(id, newCategoria);
            if (IsUpdated == true)
                return NoContent();
            return NotFound();            
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategoria(int id)
        {
            var isDeleted = _categoriaRepository.DeleteCategoria(id);
            if(isDeleted == true)
                return NoContent();
            return NotFound();
        }
    }
}
