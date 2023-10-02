using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace JeanLuis_AP1_P1.Models
{
    public class Aportes
    {
        [Key]

        public int AporteId { get; set; }

        [Required (ErrorMessage ="Debe Registrar la fecha de Aporte")]
        public DateTime Fecha { get; set; } = new DateTime();
        [Required (ErrorMessage ="Debe llenar el campo.")]
        public string? Persona { get; set; }
        [Required (ErrorMessage ="Debe llenar el campo.")]
        public string? Observacion { get; set; }
        [Required(ErrorMessage = "Debe Ingresar un Monto.")]
        public decimal? Monto { get; set; }
    }
}
