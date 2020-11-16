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
        public IQueryable<AUsuario> GetAutehnticate(string idUsuario, string contrasena)
        {
            using (var context = new Wallet_VirtualEntities())
            {
                AUsuario a = new AUsuario();
                var clientUsuario = new SqlParameter("@usuario", idUsuario);
                var clientContrasena = new SqlParameter("@contrasena", contrasena);
                
                var result = context.Database
                    .SqlQuery<AUsuario>("usp_ValidaAcceso @usuario, @contrasena", clientUsuario, clientContrasena).DefaultIfEmpty(a)
                    .ToList();

                return result.AsQueryable();
            }
        }
    }
}
