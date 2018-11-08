using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace TotalClean.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Hace Falta Nombre")]
		[StringLength(40)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Hacen Falta Apellidos")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Hace Falta Usuario")]
        public string User { get; set; }
        [Required(ErrorMessage = "Hace Falta Contraseña")]
        public string Contraseña { get; set; }
        [Compare(nameof(Contraseña),ErrorMessage = "Contraseña incorrecta")] 
        public string ConfirmarContraseña { get; set;}
        [DataType(DataType.EmailAddress, ErrorMessage = "Email invalido")]
        [Required(ErrorMessage = "Hace Falta Correo")]
        public string Correo { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Email invalido")]
        [Compare(nameof(Correo),ErrorMessage = "Email no coincide")] 
        public string ConfirmarCorreo { get; set;}
    }
}