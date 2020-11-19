using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class CajaCryptoMoneda
    {
        private int idCajaCryptoMoneda;
        private int monto;
        private int movimiento;
        private string detalle;
        public CajaCryptoMoneda()
        {

        }
        public CajaCryptoMoneda(int idCajaCryptoMoneda, int monto, int movimiento, string detalle)
        {
            this.idCajaCryptoMoneda = idCajaCryptoMoneda;
            this.monto = monto;
            this.movimiento = movimiento;
            this.detalle = detalle;
        }
        public int IdCajaCryptoMoneda { get => idCajaCryptoMoneda; set => idCajaCryptoMoneda = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Movimiento { get => movimiento; set => movimiento = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}