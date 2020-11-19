using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using Clip_banco.Models;
using System.Web.Http.Cors;

namespace Clip_banco.Controllers
{
    public class UsuarioController : ApiController
    {
        //[Authorize]
        // GET: api/Persona

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public Usuario Get(string id)
        {
            GestorUsuario gUsuario = new GestorUsuario();
            return gUsuario.ObtenerUsuario(id);
        }

        // POST: api/Persona
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public Usuario Post(Usuario usuario)
        {
            GestorUsuario gUsuario = new GestorUsuario();
            gUsuario.AgregarUsuario(usuario);
            return usuario;
        }

        // DELETE: api/Persona/5
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Delete(string id)
        {
            GestorUsuario gUsuario = new GestorUsuario();
            gUsuario.EliminarUsuario(id);

        }
    }
}
