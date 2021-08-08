using BackendChallengeAlura.Models;
using BackendChallengeAlura.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace BackendChallengeAlura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly ILogger<CategoriaController> logger;

        public CategoriaController(ICategoriaRepository categoriaRepository, ILogger<CategoriaController> logger)
        {
            this.logger = logger;
            _categoriaRepository = categoriaRepository;
        }

        [HttpPost]
        public IActionResult AddCategoria([FromBody] Categoria categoria)
        {
            _categoriaRepository.AddCategoria(categoria);
            logger.LogInformation($"Adding Categoria object, DT: {DateTime.Now}");
            return CreatedAtAction(nameof(GetCategoria), new { id = categoria.Id }, categoria);
        }

        [HttpGet]
        public IEnumerable<Categoria> GetCategoria()
        {
            logger.LogInformation($"Return Categoria collection, DT: {DateTime.Now}");
            return _categoriaRepository.GetCategoria();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetCategoria(int id)
        {
            var categoria = _categoriaRepository.GetCategoria(id);
            logger.LogInformation($"Return Categoria by ID, DT: {DateTime.Now}");
            return Ok(categoria);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategoria(int id, [FromBody] Categoria newCategoria)
        {
            var IsUpdated = _categoriaRepository.UpdateCategoria(id, newCategoria);
            if (IsUpdated == true)
            { 
                logger.LogInformation($"Updating Categoria, DT: {DateTime.Now}");
                return NoContent();
            }
            logger.LogInformation($"Tried to update Categoria, but no Categoria with such id was found, DT: {DateTime.Now}");
            return NotFound();            
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategoria(int id)
        {
            var isDeleted = _categoriaRepository.DeleteCategoria(id);
            if(isDeleted == true)
            {
                logger.LogInformation($"Deleting Categoria, DT: {DateTime.Now}");
                return NoContent();
            }
            logger.LogInformation($"Tried to delete Categoria, but no Categoria with such id was found, DT: {DateTime.Now}");
            return NotFound();
        }
    }
}
