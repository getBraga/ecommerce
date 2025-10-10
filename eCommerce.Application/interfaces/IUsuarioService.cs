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
        public IList<Usuario> Usuarios();
        public Usuario? UsuarioById(int id);
        public UsuarioDto CriarUsuario(UsuarioDto usuario);
        public UsuarioDto AtualizarUsuario(UsuarioDto usuario, int id);
        public bool DeletarUsuario(int id);
    }
}
