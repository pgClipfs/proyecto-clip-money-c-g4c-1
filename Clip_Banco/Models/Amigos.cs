using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class Amigos
    {
        private int idAmigos;
        private string idUsuario;
        private int CBU;

        public Amigos()
        {

        }
        public Amigos(int idAmigos, string idUsuario, int CBU)
        {
            this.idAmigos = idAmigos;
            this.idUsuario = idUsuario;
            this.CBU = CBU;
        }
        public int IdAmigos { get => idAmigos; set => idAmigos = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int cuentaCBU { get => CBU; set => CBU = value; }

    }
}