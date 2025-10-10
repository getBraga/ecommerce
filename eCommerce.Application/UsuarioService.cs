using eCommerce.Application.Dtos;
using eCommerce.Application.interfaces;
using eCommerce.Models;
using eCommerce.Models.interfaces;

namespace eCommerce.Application
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IList<Usuario> Usuarios()
        {
            return _usuarioRepository.Get();
        }
        public Usuario? UsuarioById(int id)
        {
            return _usuarioRepository.GetById(id);
        }


        public UsuarioDto AtualizarUsuario(UsuarioDto usuarioDto, int id)
        {
            if (usuarioDto.Id != id) throw new Exception("Id não confere!");
            var usuarioExistente = _usuarioRepository.GetById(id);
            if (usuarioExistente == null) throw new Exception("Usuário não encontrado!");
            usuarioExistente.AtualizarUsuario(
                usuarioDto.Nome,
                usuarioDto.Email,
                usuarioDto.Sexo,
                usuarioDto.RG,
                usuarioDto.CPF,
                usuarioDto.NomeMae,
                usuarioDto.SituacaoCadastro,
                null,
                null,
                null);
           

            _usuarioRepository.Update(usuarioExistente);

            return usuarioDto;
        }

        public UsuarioDto CriarUsuario(UsuarioDto dto)
        {
           
          var usuario = Usuario.CriarUsuario(
        dto.Nome,
        dto.Email,
        dto.Sexo,
        dto.RG,
        dto.CPF,
        dto.NomeMae,
        dto.SituacaoCadastro,
        null,
        null,
        null


    );
            var novoUsuario = _usuarioRepository.Add(usuario);
            dto.Id = novoUsuario.Id;
            return dto;
        }

        public bool DeletarUsuario(int id)
        {
            var deletarUsuario = _usuarioRepository.Delete(id);
            if (!deletarUsuario) throw new Exception("Usuário não encontrado!");
            return deletarUsuario;
        }


    }
}
