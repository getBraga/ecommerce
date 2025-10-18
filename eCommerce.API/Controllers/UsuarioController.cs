using eCommerce.Application.Dtos;
using eCommerce.Application.interfaces;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpGet(Name = "Usuarios")]

        public async Task<IActionResult> Get()
        {
            var usuarios = await _usuarioService.Usuarios();
            return Ok(usuarios);

        }
 
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var usuario =await  _usuarioService.UsuarioById(id);
            if(usuario ==null)
            {
                return NotFound("Usuário não encontrado!");
            }
            return Ok(usuario);
        }

        [HttpPost]
        public async Task <IActionResult> Post([FromBody]UsuarioDto usuario) {

            var result = await _usuarioService.CriarUsuario(usuario);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UsuarioDto usuario, int id)
        {

            var result = await _usuarioService.AtualizarUsuario(usuario, id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _usuarioService.DeletarUsuario(id);
            return Ok("Usuário deletado com sucesso!");
        }
    }

}
