using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<UsuarioModel> Get()
        {
            List<UsuarioModel> usuarioModels = new List<UsuarioModel>();
            usuarioModels.Add(new UsuarioModel() { Id = 1, Nome = "Davi", email = "davioliveirasanto.work@gmail.com" });
            return usuarioModels;
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public UsuarioModel Get(int id)
        {
            UsuarioModel Usuario = new UsuarioModel() { Id = 1, Nome = "Davi", email = "davioliveirasanto.work@gmail.com" };
            return Usuario;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] UsuarioModel usuario)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UsuarioModel usuario)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
