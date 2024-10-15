using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLib.Models
{
    public class Libros
    {
        [Key]

        public int LibroId { get; set; }
        [Required(ErrorMessage = "Este Campo es Obligatorio")]

        public string? Titulo { get; set; }
        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public string? Autor { get; set; }
        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public string? Genero { get; set; }
        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public bool EstaPrestado { get; set; }


    }
}
