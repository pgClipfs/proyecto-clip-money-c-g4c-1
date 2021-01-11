using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class CajaMonedaLocal
    {
        private int idMonedaLocal;
        private int monto;
        private int idIngresos;
        private int idEgresos;
        public CajaMonedaLocal()
        {

        }
        public CajaMonedaLocal(int idMonedaLocal, int monto, int ingresos, int egresos)
        {
            this.idMonedaLocal = idMonedaLocal;
            this.monto = monto;
            this.idIngresos = ingresos;
            this.idEgresos = egresos;
        }
        public int IdCajaMonedaLocal { get => idMonedaLocal; set => idMonedaLocal = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Ingresos { get => idIngresos; set => idIngresos = value; }
        public int Egresos { get => idIngresos; set => idEgresos = value; }
    }
}