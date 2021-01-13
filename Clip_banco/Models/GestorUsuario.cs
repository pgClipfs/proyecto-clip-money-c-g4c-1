using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Clip_banco.Models
{
    public class GestorUsuario
    {
        public void AgregarUsuario(Usuario usuario)
        {
            string StrConn = "Data Source=DESKTOP-TC83RVK\\SQLEXPRESS; Initial Catalog=MonederoVirtual; Integrated Security=True;";


            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "insertar_usuario";
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@idUsuario", usuario.IdUsuario));
                comm.Parameters.Add(new SqlParameter("@contrasena", usuario.Contrasena));
                comm.Parameters.Add(new SqlParameter("@correo", usuario.CorreoElectronico));

            }
        }
        public void EliminarUsuario(string id)
        {
            string StrConn = "Data Source=DESKTOP-TC83RVK\\SQLEXPRESS; Initial Catalog=MonederoVirtual; Integrated Security=True;";


            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("eliminar_usuario", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@idUsuario", id));

                comm.ExecuteNonQuery();
            }
        }
        public Usuario ObtenerUsuario(string id)
        {
            Usuario p = null;
            string StrConn = "Data Source=DESKTOP-TC83RVK\\SQLEXPRESS; Initial Catalog=MonederoVirtual; Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("obtener_usuario", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@idUsuario", id));

                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    int dni = dr.GetInt32(1);
                    string nombre = dr.GetString(2);
                    string apellido = dr.GetString(3);
                    string contrasena = dr.GetString(4);
                    int telefono = dr.GetInt32(5);
                    string correoElectronico = dr.GetString(6);
                    string direccion = dr.GetString(7);
                    int numeracion = dr.GetInt32(8);
                    p = new Usuario(id, dni, nombre, apellido, contrasena, telefono, correoElectronico, direccion, numeracion);
                }

                dr.Close();
            }

            return p;
        }
    }
}