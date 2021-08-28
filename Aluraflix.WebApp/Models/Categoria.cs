using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallengeAlura.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Cor { get; set; }
        public IEnumerable<Video> Videos { get; set; }
    }
}
