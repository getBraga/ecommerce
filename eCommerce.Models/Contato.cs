using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Contato
    {
        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public string? Telefone { get; private set; }
        public string? Celular { get; private set; }
        public Usuario Usuario { get; private set; } = null!;
        public Contato(int usuarioId, string? telefone, string? celular, Usuario usuario)
        {
            SetCelular(celular);
            SetTelefone(telefone);
            SetUsuarioId(usuarioId);
            SetUsuario(usuario);    
        }
        
        public void SetUsuario(Usuario usuario)
        {
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario), "Usuário não pode ser nulo");
            UsuarioId = usuario.Id;
        }
        public void SetUsuarioId(int usuarioId)
        {
            if (usuarioId < 0) throw new ArgumentException("Id de usuário inválido", nameof(usuarioId));
            UsuarioId = usuarioId;
        }
        public void SetTelefone(string? telefone)
        {
            Telefone = telefone;
        }
        public void SetCelular(string? celular)
        {
            Celular = celular;
        }
        public void CriarContato(int usuarioId, string? telefone, string? celular, Usuario usuario)
        {
            if (usuarioId < 0) throw new ArgumentException("Id de usuário inválido", nameof(usuarioId));
            UsuarioId = usuarioId;
            Telefone = telefone;
            Celular = celular;
            Usuario = usuario;
        }

        public void AtualizarContato(int id, int usuarioId, string? telefone, string? celular, Usuario usuario)
        {
            if(id < 0 ) throw new ArgumentException("Id inválido", nameof(id));
            if(usuarioId < 0) throw new ArgumentException("Id de usuário inválido", nameof(usuarioId)); 
            Id = id;
            UsuarioId = usuarioId;
            Telefone = telefone;
            Celular = celular;
            Usuario = usuario;
        }
    }

}


