using System.ComponentModel.DataAnnotations;

namespace Cabelos_do_Taeyong.Models
{
    public class Cabelos
    {
        public int Id {get; set;}

        [Required]

        public string Cor_do_Cabelo {get; set;}

        public string Era {get; set;}

        [Required]

        public int Ano {get; set;}

        [Required]
        [Range(0, 10)]
        public decimal Nota {get; set;}

        public string Comentario {get; set;}
    }
}