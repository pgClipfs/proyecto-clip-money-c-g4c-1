using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class GestorLogin
    {
        public bool ValidarLogin(Usuario loginRequest)
        {
            string strConn = "Data Source=DESKTOP-TC83RVK\\SQLEXPRESS; Initial Catalog=MonederoVirtual; Integrated Security=True;";
            bool result = false;

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("obtener_login", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@username", loginRequest.IdUsuario));
                comm.Parameters.Add(new SqlParameter("@password", loginRequest.Contrasena));

                SqlDataReader reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    result = true;
                }

            }
            return result;

        }
        public Usuario ObtenerUsuario(string id)
        {
            Usuario p = null;
            string StrConn = "Data Source=DESKTOP-TC83RVK\\SQLEXPRESS; Initial Catalog=MonederoVirtual; Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("obtener_login", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@idUsuario", id));

                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    int dni = dr.GetInt32(1);
                    string nombre = dr.GetString(2);
                    string apellido = dr.GetString(3);
                    string contrasena = dr.GetString(4);
                    string correoElectronico = dr.GetString(5);
                    string direccion = dr.GetString(6);
                    int numeracion = dr.GetInt32(7);
                    int telefono = dr.GetInt32(6);
                    p = new Usuario(id, dni, nombre, apellido, contrasena, telefono, correoElectronico, direccion, numeracion);
                }

                dr.Close();
            }

            return p;
        }
    }
}