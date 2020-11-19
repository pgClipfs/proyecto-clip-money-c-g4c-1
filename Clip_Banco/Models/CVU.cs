using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class CVU
    {
        private string idCVU;
        private string idUsuario;
        private int idCajaMonedaLocal;
        private int idCajaMonedaExtranjera;
        private int idCajaCryptoMoneda;
        private int idOperacion;
        public CVU()
        {

        }
        public CVU(string idCVU, string idUsuario, int idCajaMonedaLocal, int idCajaMonedaExtranjera, int idCajaCryptoMoneda, int idOperacion)
        {
            this.idCVU = idCVU;
            this.idUsuario = idUsuario;
            this.idCajaMonedaLocal = idCajaMonedaLocal;
            this.idCajaMonedaExtranjera = idCajaMonedaExtranjera;
            this.idCajaCryptoMoneda = idCajaCryptoMoneda;
            this.idOperacion = idOperacion;
        }
        public string IdCVU { get => idCVU; set => idCVU = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdCajaMonedaLocal { get => idCajaMonedaLocal; set => idCajaMonedaLocal = value; }
        public int IdCajaMonedaExtranjera { get => idCajaMonedaExtranjera; set => idCajaMonedaExtranjera = value; }
        public int IdCajaCryptoMoneda { get => idCajaCryptoMoneda; set => idCajaCryptoMoneda = value; }
        public int IdOperacion { get => IdOperacion; set => IdOperacion = value; }
    }
}