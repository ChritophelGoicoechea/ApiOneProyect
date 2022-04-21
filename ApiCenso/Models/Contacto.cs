using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCenso.Models
{
    public class Contacto
    {

        public int Id { get; set; }
        public string numero { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string formacion { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public DateTime fecha { get; set; }



    }
}
