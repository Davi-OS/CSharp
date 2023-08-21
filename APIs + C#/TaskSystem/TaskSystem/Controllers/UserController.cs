using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskSystem.Models;
using TaskSystem.Repository;
using TaskSystem.Repository.Interfaces;

namespace TaskSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> BuscarTodosUsuarios()
        {
           List<UserModel> Usuarios = await _userRepository.BuscaTodsUsuarios();
            return Ok(Usuarios);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> BuscarPorid(int id)
        {
            UserModel Resp = await _userRepository.BuscarPorId(id);
            return Ok(Resp);
        }
        [HttpPost]
        public async Task<ActionResult<UserModel>> Cadastrar([FromBody] UserModel usuarioModel)
        {
            UserModel usuario = await _userRepository.Add(usuarioModel);
            return Ok(usuario);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<UserModel>> Atualizar([FromBody] UserModel usuarioModel,int id)
        {
            usuarioModel.Id = id;
            UserModel usuario = await _userRepository.Update(usuarioModel,id);
            return Ok(usuario);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserModel>> Apagar(int id)
        {
            bool apagado = await _userRepository.Delete(id);
            return Ok(apagado);
        }

    }
}
