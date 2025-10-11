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
        protected Contato()
        {
            
        }

        public static Contato CriarContato(int usuarioId, string? telefone, string? celular, Usuario usuario)
        {
            var contato = new Contato();
            contato.IncluirContato(usuarioId, telefone, celular, usuario);
            return contato;
        }
        public void AtualizarContato(int id, int usuarioId, string? telefone, string? celular, Usuario usuario)
        {
            UpdateContato(id, usuarioId, telefone, celular, usuario);
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
        private void IncluirContato(int usuarioId, string? telefone, string? celular, Usuario usuario)
        {
            SetUsuario(usuario);
            SetUsuarioId(usuarioId);
            SetTelefone(telefone);
            SetCelular(celular);
        }

        private void UpdateContato(int id, int usuarioId, string? telefone, string? celular, Usuario usuario)
        {
            if (id < 0) throw new ArgumentException("Id inválido", nameof(id));
            Id = id;
            SetUsuario(usuario);
            SetUsuarioId(usuarioId);
            SetTelefone(telefone);
            SetCelular(celular);


        }
    }

}


