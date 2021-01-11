using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class Cuenta
    {
        private int CBU;
        private string idUsuario;
        private int idCajaMonedaLocal;
        private int idHistorial;
        private int idAmigos;
        public Cuenta()
        {

        }
        public Cuenta(int CBU, string idUsuario, int idCajaMonedaLocal, int idHistorial, int idAmigos)
        {
            this.CBU = CBU;
            this.idUsuario = idUsuario;
            this.idCajaMonedaLocal = idCajaMonedaLocal;
            this.idHistorial = idHistorial;
            this.idAmigos = idAmigos;
        }
        public int IdCVU { get => CBU; set => CBU = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdCajaMonedaLocal { get => idCajaMonedaLocal; set => idCajaMonedaLocal = value; }
        public int IdAmigos { get => idAmigos; set => idAmigos = value; }
        public int IdHistorial { get => IdHistorial; set => IdHistorial = value; }
    }
}