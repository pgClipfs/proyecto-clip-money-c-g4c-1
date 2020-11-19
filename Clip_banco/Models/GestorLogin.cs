using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Clip_banco.Models
{
    public class GestorLogin
    {
        public bool ValidarLogin(LoginRequest ploginRequest)
        {
            string strConn = "Server=DESKTOP-TC83RVK\\SQLEXPRESS; Database=Wallet_Virtual; Trusted_Connection=True;";
            bool result = false;

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("obtener_login", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@username", ploginRequest.Username));
                comm.Parameters.Add(new SqlParameter("@password", ploginRequest.Password));

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