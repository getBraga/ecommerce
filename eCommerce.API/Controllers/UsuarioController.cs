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

        public IActionResult Get()
        {
            var usuarios = _usuarioService.Usuarios();
            return Ok(usuarios);

        }
 
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var usuario = _usuarioService.UsuarioById(id);
            if(usuario ==null)
            {
                return NotFound("Usuário não encontrado!");
            }
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Post([FromBody]UsuarioDto usuario) {

            var result = _usuarioService.CriarUsuario(usuario);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put(UsuarioDto usuario, int id)
        {

            var result = _usuarioService.AtualizarUsuario(usuario, id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioService.DeletarUsuario(id);
            return Ok("Usuário deletado com sucesso!");
        }
    }

}
