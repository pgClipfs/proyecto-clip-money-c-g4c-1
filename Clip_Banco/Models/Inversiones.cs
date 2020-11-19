using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class Inversiones
    {
        private int idOperacion;
        private int monto;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string tipoMoneda;
        public Inversiones()
        {

        }
        public Inversiones(int idOperacion, int monto, DateTime fechaInicio, DateTime fechaFin, string tipoMoneda)
        {
            this.idOperacion = idOperacion;
            this.monto = monto;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.tipoMoneda = tipoMoneda;
        }
        public int IdOperacion { get => idOperacion; set => idOperacion = value; }
        public int Monto { get => monto; set => monto = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string TipoMoneda { get => tipoMoneda; set => tipoMoneda = value; }
    }
}