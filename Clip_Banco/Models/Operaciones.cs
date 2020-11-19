using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class Operaciones
    {
        private int idOperacion;
        private string idCVU;
        private string operacionTipo;
        private string operacionDescripcion;
        public Operaciones()
        {

        }
        public Operaciones(int idOperacion, string idCVU, string operacionTipo, string operacionDescripcion)
        {
            this.idOperacion = idOperacion;
            this.idCVU = idCVU;
            this.operacionTipo = operacionTipo;
            this.operacionDescripcion = operacionDescripcion;
        }
        public int IdOperacion { get => idOperacion; set => idOperacion = value; }
        public string IdCVU { get => idCVU; set => idCVU = value; }
        public string OperacionTipo { get => operacionTipo; set => operacionTipo = value; }
        public string OperacionDescripcion { get => operacionDescripcion; set => operacionDescripcion = value; }
    }
}