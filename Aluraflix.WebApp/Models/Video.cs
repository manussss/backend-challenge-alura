using System;
using System.ComponentModel.DataAnnotations;

namespace BackendChallengeAlura.Models
{
    public class Video
    {
        public int Id { get; set; }

        public Categoria Categoria { get; set; }

        public int CategoriaId { get; set; }

        public string Titulo { get; set; }
        
        public string Descricao { get; set; }
        
        public string Url { get; set; }
    }
}
