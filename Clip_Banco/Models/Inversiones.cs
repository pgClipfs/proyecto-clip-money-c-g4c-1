//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clip_Banco.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inversiones
    {
        public int idOperacion { get; set; }
        public int Monto { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string tipoMoneda { get; set; }
    
        public virtual Operaciones Operaciones { get; set; }
    }
}