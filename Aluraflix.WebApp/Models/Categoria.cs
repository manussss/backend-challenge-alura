using System.Collections.Generic;

namespace Aluraflix.WebApp.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Cor { get; set; }
        public IEnumerable<Video> Videos { get; set; }
    }
}
