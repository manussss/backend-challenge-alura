using System;
using System.ComponentModel.DataAnnotations;

namespace BackendChallengeAlura.Models
{
    public class Video
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo títutlo é obrigatório")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage = "A URL é obrigatória")]
        public string Url { get; set; }
    }
}
