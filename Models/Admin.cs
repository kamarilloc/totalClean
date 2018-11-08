using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//Creating class
namespace TotalClean.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contraseña { get; set; }
  
    }
}