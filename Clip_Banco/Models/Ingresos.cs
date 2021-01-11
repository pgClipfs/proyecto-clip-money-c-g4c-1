using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class Ingresos
    {
        private int idIngresos;
        private DateTime fecha;
        private int monto;
        private string detalle;

        public Ingresos() { }
        public Ingresos(int idIngresos, DateTime fecha, int monto, string detalle)
        {
            this.idIngresos = idIngresos;
            this.fecha = fecha;
            this.monto = monto;
            this.detalle = detalle;
        }
        public int IdEgresos { get => idIngresos; set => idIngresos = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Monto { get => monto; set => monto = value; }
        public string Deatelle { get => detalle; set => detalle = value; }
    }
}