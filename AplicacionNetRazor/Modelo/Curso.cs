using System.ComponentModel.DataAnnotations;

namespace AplicacionNetRazor.Modelo
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre del Curso")]
        public string NombreCurso { get; set; }
        [Display(Name ="Cantidad de Clases")]
        public int CantidadClases { get; set; }
        public int Precio { get; set; }
        [Display(Name ="Fecha de creacion")]
        public DateTime FechaCreacion { get; set; }
    }
}
