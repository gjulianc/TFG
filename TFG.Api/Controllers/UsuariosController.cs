using EFCore;
using EFData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TFG.Contrato;

namespace TFG.Api.Controllers
{
    public class UsuariosController : ApiController
    {
        private IRepositoryUsuarios usuarioRepository;
        // GET: api/Usuarios
        public string Get()
        {            
            usuarioRepository = new UsuarioMap();
            List<Usuario> usuarios = usuarioRepository.GetAllUsers();

            string json = JsonConvert.SerializeObject(usuarios);

            return json;
        }

        // GET: api/Usuarios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuarios
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
        }
    }
}
