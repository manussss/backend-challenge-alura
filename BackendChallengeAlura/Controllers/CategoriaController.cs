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

        /// <summary>
        /// Adicionar uma categoria.
        /// </summary>
        /// <param name="categoria">Categoria que será adicionada.</param>
        /// <response code="201">Uma nova categoria foi adicionada com sucesso.</response>
        [HttpPost]
        public IActionResult AddCategoria([FromBody] Categoria categoria)
        {
            _categoriaRepository.AddCategoria(categoria);
            logger.LogInformation($"Adding Categoria object, DT: {DateTime.Now}");
            return CreatedAtAction(nameof(GetCategoria), new { id = categoria.Id }, categoria);
        }

        /// <summary>
        /// Obter lista de categorias.
        /// </summary>
        /// <response code="200">A lista de categorias foi obtida.</response>
        [HttpGet]
        public IEnumerable<Categoria> GetCategoria()
        {
            logger.LogInformation($"Return Categoria collection, DT: {DateTime.Now}");
            return _categoriaRepository.GetCategoria();
        }

        /// <summary>
        /// Obter categorias por ID.
        /// </summary>
        /// <param name="id">ID da categoria.</param>
        /// <response code="200">A categoria foi obtida com sucesso.</response>
        [HttpGet("{id}")]
        public IActionResult GetCategoria(int id)
        {
            var categoria = _categoriaRepository.GetCategoria(id);
            logger.LogInformation($"Return Categoria by ID, DT: {DateTime.Now}");
            return Ok(categoria);
        }

        /// <summary>
        /// Alterar categoria.
        /// </summary>
        /// <param name="id">ID da categoria.</param>
        /// <param name="newCategoria">Nova categoria.</param>
        /// <response code="204">A categoria foi alterada com sucesso.</response>
        /// <response code="404">Nenhuma categoria com esse ID foi encontrada.</response>
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

        /// <summary>
        /// Deletar uma categoria.
        /// </summary>
        /// <param name="id">ID da categoria.</param>
        /// <response code="204">A categoria foi deletada com sucesso.</response>
        /// <response code="404">Nenhuma categoria com esse ID foi encontrada.</response>
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
