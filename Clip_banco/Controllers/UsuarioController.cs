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
    [RoutePrefix("api/register")]
    public class UserController : ApiController
    {

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<Usuario> Get()
        {
            List<Usuario> lista = new List<Usuario>();
            return lista;
        }

        [HttpPost]
        [Route("newUser")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public Usuario PostNuevo(Usuario usuario)
        {
            int id;
            GestorUsuario gUsuario = new GestorUsuario();
            id = gUsuario.AgregarUsuario(usuario);
            usuario.Id = id;
            return usuario;
        }

        [HttpPost]
        [Route("modifyUser")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public Usuario PostModificado(Usuario usuariomodifcado)
        {
            int idAuto;
            GestorUsuario mUsuario = new GestorUsuario();
            idAuto = mUsuario.ObtenerUsuario(usuariomodifcado);
            return usuariomodifcado;
        }

    }
}
