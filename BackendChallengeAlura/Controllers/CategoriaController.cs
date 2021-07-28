using BackendChallengeAlura.Data;
using BackendChallengeAlura.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BackendChallengeAlura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private VideoContext _context;

        public CategoriaController(VideoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCategoria), new { id = categoria.Id }, categoria);
        }

        [HttpGet]
        public IEnumerable<Categoria> GetCategoria()
        {
            return _context.Categorias;
        }
        
        [HttpGet("{id}")]
        public IActionResult GetCategoria(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            return Ok(categoria);
        }
    }
}
