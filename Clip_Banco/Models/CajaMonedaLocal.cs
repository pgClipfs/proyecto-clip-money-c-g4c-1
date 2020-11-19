using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class CajaMonedaLocal
    {
        private int idCajaMonedaLocal;
        private int monto;
        private int movimiento;
        private string detalle;
        public CajaMonedaLocal()
        {

        }
        public CajaMonedaLocal(int idCajaMonedaLocal, int monto, int movimiento, string detalle)
        {
            this.idCajaMonedaLocal = idCajaMonedaLocal;
            this.monto = monto;
            this.movimiento = movimiento;
            this.detalle = detalle;
        }
        public int IdCajaMonedaLocal { get => idCajaMonedaLocal; set => idCajaMonedaLocal = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Movimiento { get => movimiento; set => movimiento = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}