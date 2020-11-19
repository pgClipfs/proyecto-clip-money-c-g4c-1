using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class CajaMonedaExtranjera
    {
        private int idCajaMonedaExtranjera;
        private int monto;
        private int movimiento;
        private string detalle;
        public CajaMonedaExtranjera()
        {

        }
        public CajaMonedaExtranjera(int idCajaMonedaExtranjera, int monto, int movimiento, string detalle)
        {
            this.idCajaMonedaExtranjera = idCajaMonedaExtranjera;
            this.monto = monto;
            this.movimiento = movimiento;
            this.detalle = detalle;
        }
        public int IdCajaMonedaExtranjera { get => idCajaMonedaExtranjera; set => idCajaMonedaExtranjera = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Movimiento { get => movimiento; set => movimiento = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}