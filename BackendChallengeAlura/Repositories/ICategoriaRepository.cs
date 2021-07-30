using BackendChallengeAlura.Models;
using System.Collections.Generic;

namespace BackendChallengeAlura.Repositories
{
    public interface ICategoriaRepository
    {
        void AddCategoria(Categoria categoria);
        IEnumerable<Categoria> GetCategoria();
        Categoria GetCategoria(int id);
        bool UpdateCategoria(int id, Categoria newCategoria);
        bool DeleteCategoria(int id);
    }
}
