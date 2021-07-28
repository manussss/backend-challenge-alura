using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallengeAlura.Models
{
    public class Categoria
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo títutlo é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo cor é obrigatório")]
        public string Cor { get; set; }
    }
}
