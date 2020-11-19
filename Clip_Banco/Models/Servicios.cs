using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class Servicios
    {
        private int idOperacion;
        private string tipoServicio;
        private float montoDeuda;
        private int idFactura;
        public Servicios()
        {

        }
        public Servicios(int idOperacion, string tipoServicio, float montoDeuda, int idFactura)
        {
            this.idOperacion = idFactura;
            this.tipoServicio = tipoServicio;
            this.montoDeuda = montoDeuda;
            this.idFactura = idFactura;
        }

        public int IdOperacion { get => idOperacion; set => idOperacion = value; }
        public string TipoServicio { get => tipoServicio; set => tipoServicio = value; }
        public float MontoDeuda { get => montoDeuda; set => montoDeuda = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }
    }
}