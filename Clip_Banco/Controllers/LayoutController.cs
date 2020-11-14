using Clip_Banco.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Clip_Banco.Controllers
{
    public class LayoutController : ApiController
    {
        
        [ResponseType(typeof(Accesousuario))]
        public IHttpActionResult GetAccesoPerfil(int idUsuario)
        {
            var vAccesoperfil = new Accesousuario();
            List<Usuarioperfil> vLstUsuario = new List<Usuarioperfil>();

            using (var db = new Wallet_VirtualEntities())
            {
                
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "usp_ValidaAcceso";
                cmd.CommandType = CommandType.StoredProcedure;

                DbParameter param = cmd.CreateParameter();
                param.ParameterName = "@idUsuario";
                param.DbType = DbType.Int32;
                param.Direction = ParameterDirection.Input;
                param.Value = idUsuario;

                cmd.Parameters.Add(param);

                try
                {

                    db.Database.Connection.Open();
                    // Run the sproc
                    var reader = cmd.ExecuteReader();

                    // Read Blogs from the first result set
                    var vUsuario = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<Usuarioperfil>(reader, "perfil", MergeOption.AppendOnly);


                    foreach (var item in vUsuario)
                    {
                        Usuarioperfil oUsuario = new Usuarioperfil();
                        oUsuario.idUsuario = item.idUsuario;
                        oUsuario.contraseña = item.contraseña;
                    }
                    /*
                    // Move to second result set and read Posts
                    reader.NextResult();
                    var vUsuario = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<Usuarioperfil>(reader, "Posts", MergeOption.AppendOnly);


                    foreach (var item in vUsuario)
                    {
                        Console.WriteLine(item.Title);
                    }
                    */
                    vAccesoperfil.perfil = vLstUsuario;

                    return Ok(vAccesoperfil);
                }
                finally
                {
                    db.Database.Connection.Close();
                }
            }
        }
        
    }
}
