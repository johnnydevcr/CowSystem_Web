using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CowSystem.Models
{
    public class TipoGanadoViewModel
    {
        [Key]
        public int IdTipoGanado { get; set; }
        [DisplayName("Descripción")]
        [Required]
        [MaxLength(100,ErrorMessage ="Debe tener menos de 100 caracteres")]
        public string Descripcion { get; set; }
        [DisplayName("Actualización")]
        public string UltimaActualizacion { get; set; }
    }
}