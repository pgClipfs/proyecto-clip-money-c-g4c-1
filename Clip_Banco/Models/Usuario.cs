using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class Usuario
    {
        private string idUsuario;
        private int DNI;
        private string nombre;
        private string apellido;
        private string contrasena;
        private string correoElectronico;
        private int telefono;
        private DateTime fechaRegistro;
        private bool status;

        public Usuario()
        {

        }
        public Usuario(string idUsuario, int DNI, string nombre, string apellido, string contrasena, string correoElectronico, int telefono, DateTime fechaRegistro, bool status)
        {
            this.idUsuario = idUsuario;
            this.DNI = DNI;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contrasena = contrasena;
            this.correoElectronico = correoElectronico;
            this.telefono = telefono;
            this.fechaRegistro = fechaRegistro;
            this.status = status;
        }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int dni { get => DNI; set => DNI = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public bool Status { get => status; set => status = value; }
    }
}