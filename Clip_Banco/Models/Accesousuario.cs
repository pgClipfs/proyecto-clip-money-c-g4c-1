using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_Banco.Models
{
    public class Accesousuario
    {
        public List<Usuarioperfil> perfil { get; set; }
    }
    public class Usuarioperfil
    {
        public int idUsuario { get; set; }
        public int DNI { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int contraseña { get; set; }
        public string correoElectronico { get; set; }
        public int telefono { get; set; }
    }

}