using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class Egresos
    {
        private int idEgresos;
        private DateTime fecha;
        private int monto;
        private string detalle;

        public Egresos() { }
        public Egresos(int idEgresos, DateTime fecha, int monto, string detalle)
        {
            this.idEgresos = idEgresos;
            this.fecha = fecha;
            this.monto = monto;
            this.detalle = detalle;
        }
        public int IdEgresos { get => idEgresos; set => idEgresos = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Monto { get => monto; set => monto = value; }
        public string Deatelle { get => detalle; set => detalle = value; }
    }
}