using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluacionT1_DIARS.Models
{
    public class Account
    {

        public int id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="Campo Requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int Dia { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int Mes { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int Anio { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string DNI { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Correo { get; set; }
        
      
    }
}
