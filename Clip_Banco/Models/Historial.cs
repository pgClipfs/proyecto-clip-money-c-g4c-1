using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class Historial
    {
        private int idHistorial;
        private int idIngresos;
        private int idEgresos;

        public Historial() { }
        public Historial(int idHistorial, int idIngresos, int idEgresos)
        {
            this.idHistorial = idHistorial;
            this.idIngresos = idIngresos;
            this.idEgresos = idEgresos;
        }

        public int IdHistorial { get => idHistorial; set => idHistorial = value; }
        public int IdIngresos { get => idIngresos; set => idIngresos = value; }
        public int IdEgresos { get => idEgresos; set => idEgresos = value; }
    }
}