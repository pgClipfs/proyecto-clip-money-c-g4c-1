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
        public int AgregarUsuario(Usuario usuario)
        {
            string StrConn = "Data Source=DESKTOP-TC83RVK\\SQLEXPRESS; Initial Catalog=MonederoVirtual; Integrated Security=True;";
            int id = 0;

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "insertar_usuario";
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@idUsuario", usuario.IdUsuario));
                comm.Parameters.Add(new SqlParameter("@dni", usuario.dni));
                comm.Parameters.Add(new SqlParameter("@nombre", usuario.Nombre));
                comm.Parameters.Add(new SqlParameter("@apellido", usuario.Apellido));
                comm.Parameters.Add(new SqlParameter("@contrasena", usuario.Contrasena));
                comm.Parameters.Add(new SqlParameter("@correo", usuario.CorreoElectronico));
                comm.Parameters.Add(new SqlParameter("@telefono", usuario.Telefono));
                comm.Parameters.Add(new SqlParameter("@direccion", usuario.Direccion));
                comm.Parameters.Add(new SqlParameter("@numeracion", usuario.Numeracion));

                id = Convert.ToInt32(comm.ExecuteScalar());

            }
            return id;


        }


        public int ObtenerUsuario(Usuario usuarioId)
        {
            string StrConn = "Data Source=DESKTOP-U1Q7F01\\SQLEXPRESS; Initial Catalog=MonederoVirtual; Integrated Security=True;";
            int id = 0;

            using (SqlConnection connec = new SqlConnection(StrConn))
            {
                connec.Open();

                SqlCommand comm = new SqlCommand("obtener_usuario", connec);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@idUsuario", usuarioId.IdUsuario));
                comm.Parameters.Add(new SqlParameter("@contraseña", usuarioId.Contrasena));

                id = Convert.ToInt32(comm.ExecuteScalar());
            }
            return id;
        }
    }
}