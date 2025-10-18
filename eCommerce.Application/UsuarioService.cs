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
        public async Task<IList<Usuario>> Usuarios()
        {
            return await _usuarioRepository.Get();
        }
        public async Task<Usuario?> UsuarioById(int id)
        {
            return await _usuarioRepository.GetById(id);
        }


        public async Task<UsuarioDto> AtualizarUsuario(UsuarioDto usuarioDto, int id)
        {
            if (usuarioDto.Id != id) throw new Exception("Id não confere!");

            var usuario = Usuario.AtualizarUsuario(
                id,
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


            await _usuarioRepository.Update(usuario);

            return usuarioDto;
        }

        public async Task<UsuarioDto> CriarUsuario(UsuarioDto dto)
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
            var novoUsuario = await _usuarioRepository.Add(usuario);
            dto.Id = novoUsuario.Id;
            return dto;
        }

        public async Task<bool> DeletarUsuario(int id)
        {
            var deletarUsuario = await _usuarioRepository.Delete(id);
            if (!deletarUsuario) throw new Exception("Usuário não encontrado!");
            return deletarUsuario;
        }


    }
}
