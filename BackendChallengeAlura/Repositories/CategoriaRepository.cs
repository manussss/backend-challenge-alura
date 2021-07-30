using BackendChallengeAlura.Data;
using BackendChallengeAlura.Models;
using System.Collections.Generic;
using System.Linq;

namespace BackendChallengeAlura.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly VideoContext _context;

        public CategoriaRepository(VideoContext context)
        {
            _context = context;
        }
        public void AddCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public bool DeleteCategoria(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria == null)
                return false;

            _context.Remove(categoria);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Categoria> GetCategoria()
        {
            return _context.Categorias;
        }

        public Categoria GetCategoria(int id)
        {
            var categoria =_context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            return categoria;
        }

        public bool UpdateCategoria(int id, Categoria newCategoria)
        {
            var categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria == null)
                return false;

            categoria.Titulo = newCategoria.Titulo;
            categoria.Cor = newCategoria.Cor;
            _context.SaveChanges();
            return true;
        }
    }
}
