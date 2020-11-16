using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_Banco.Models
{
    public class AUsuario
    {
        public string idUsuario { get; set; }
        public int DNI { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string contrasena { get; set; }
        public string correoElectronico { get; set; }
        public int telefono { get; set; }
    }
}