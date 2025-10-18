using eCommerce.Application.Dtos;
using eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.interfaces
{
    public interface IUsuarioService
    {
        public Task<IList<Usuario>> Usuarios();
        public Task<Usuario?> UsuarioById(int id);
        public Task<UsuarioDto> CriarUsuario(UsuarioDto usuario);
        public Task<UsuarioDto> AtualizarUsuario(UsuarioDto usuario, int id);
        public Task<bool> DeletarUsuario(int id);
    }
}
