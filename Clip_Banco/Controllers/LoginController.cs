using Clip_Banco.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Clip_Banco.Controllers
{
    public class LoginController : ApiController
    {
        public IQueryable<AUsuario> GetAutehnticate(string usuario, string contrasena)
        {
            using (var context = new Wallet_VirtualEntities())
            {
                var clientUsuario = new SqlParameter("@usuario", usuario);
                var clientContrasena = new SqlParameter("@contrasena", contrasena);
                
                /*
                var result = context.Database
                    .SqlQuery<AUsuario>("usp_ValidaAcceso @usuario, @contrasena", usuario, contrasena)
                    .ToList();
                */

                var result = context.Database.SqlQuery<AUsuario>(
                    "exec usp_ValidaAcceso @usuario",
                    new SqlParameter("usuario", usuario)).ToList<AUsuario>();

                return result.AsQueryable();
            }
        }
    }
}
