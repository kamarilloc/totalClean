using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TotalClean.Models
{
    public class Hogar
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Hace Falta Usuario")]
        public string User { get; set; }
        [Required(ErrorMessage = "Hace Falta Indicar Un Número Telefonico")]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "Hace Falta Escoger Un Dia")]
        public DateTime Dia { get; set; }
        [Required(ErrorMessage = "Hace Falta Seleccionr Horas")]
        public int Horas { get; set; }
        [Required(ErrorMessage = "Hace Falta Indicar Ciudad")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "Hace Falta Indicar Distrito")]
        public string Distrito{ get; set; }
        [Required(ErrorMessage = "Hace Falta Indicar Direccion")]

        public string Direccion { get; set; }
        [Required(ErrorMessage = "Hace Falta Indicar Un Tipo")]
        public string Tipo { get; set; }
    }
        
}