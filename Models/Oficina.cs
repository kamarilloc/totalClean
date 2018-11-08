using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TotalClean.Models
{
    public class Oficina
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Hace Falta Usuario")]
        public string User { get; set; }
        [Required(ErrorMessage = "Hace Falta Nombre")]
		[StringLength(40)]
        public string Empresa { get; set; }
        [Required(ErrorMessage = "Hace Falta RUC")]
        public int RUC { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Email invalido")]
        public string Correo { get; set; }
        
        public int? Telefono { get; set; }
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
    }
        
}