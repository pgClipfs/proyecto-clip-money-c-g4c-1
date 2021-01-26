using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class GestorLogin
    {
        public bool ValidarLogin(LoginRequest loginRequest)
        {
            string strConn = "Data Source=DESKTOP-U1Q7F01\\SQLEXPRESS; Initial Catalog=MonederoVirtual; Integrated Security=True;";
            bool result = false;

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("obtener_login", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@username", loginRequest.Username));
                comm.Parameters.Add(new SqlParameter("@password", loginRequest.Password));

                SqlDataReader reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    result = true;
                }

            }
            return result;

        }
    }
}