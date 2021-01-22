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
        private string contraseña;
        private string email;
        private int telefono;
        private string direccion;
        private int numeracion;
        private string token;
        private int id;

        public Usuario()
        {

        }
        public Usuario(string idUsuario, string token)
        {
            this.idUsuario = idUsuario;
            this.token = token;
        }
        public Usuario(string idUsuario, int DNI, string nombre, string apellido, string contrasena, int telefono, string correoElectronico, string direccion, int numeracion, int id)
        {
            this.idUsuario = idUsuario;
            this.DNI = DNI;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contrasena;
            this.email = correoElectronico;
            this.telefono = telefono;
            this.direccion = direccion;
            this.numeracion = numeracion;
            this.id = id;
        }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int dni { get => DNI; set => DNI = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Contrasena { get => contraseña; set => contraseña = value; }
        public string CorreoElectronico { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Numeracion { get => numeracion; set => numeracion = value; }
        public int Id { get => id; set => id = value; }
        public string Token { get => token; set => token = value; }

    }
}