using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class Factura
    {
        private int idFactura;
        private string detalles;
        private DateTime vencimiento;
        public Factura()
        {

        }
        public Factura(int idFactura, string detalles, DateTime vencimiento)
        {
            this.idFactura = idFactura;
            this.detalles = detalles;
            this.vencimiento = vencimiento;
        }
        public int IdFactura { get => idFactura; set => idFactura = value; }
        public string Detalles { get => detalles; set => detalles = value; }
        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }
    }
}