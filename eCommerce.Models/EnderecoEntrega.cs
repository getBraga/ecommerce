using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class EnderecoEntrega
    {
        public int Id { get; private set; }
        public int UsuarioId { get; set; }
        public string NomeEndereco { get; private set; } = null!;
        public string CEP { get; private set; } = null!;
        public string Estado { get; private set; } = null!;
        public string Cidade { get; private set; } = null!;
        public string Bairro { get; private set; } = null!;
        public string Endereco { get; private set; } = null!;
        public string? Numero { get; private set; }
        public string? Complemento { get; private set; }
        public Usuario Usuario { get; private set; } = null!;


        protected EnderecoEntrega()
        {

        }

        public static EnderecoEntrega CriarEnderecoEntrega(int usuarioId, string nomeEndereco, string cep, string estado, string cidade, string bairro, string endereco, string? numero, string? complemento, Usuario usuario)
        {
            var enderecoEntrega = new EnderecoEntrega();
            enderecoEntrega.IncluirEnderecoEntrega(usuarioId, nomeEndereco, cep, estado, cidade, bairro, endereco, numero, complemento, usuario);
            return enderecoEntrega;
        }
        public void AtualizarEnderecoEntrega(int id, int usuarioId, string nomeEndereco, string cep, string estado, string cidade, string bairro, string endereco, string? numero, string? complemento, Usuario usuario)
        {
            UpdateEnderecoEntrega(id, usuarioId, nomeEndereco, cep, estado, cidade, bairro, endereco, numero, complemento, usuario);
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
        public void SetNomeEndereco(string nomeEndereco)
        {
            if (string.IsNullOrWhiteSpace(nomeEndereco))
            {
                throw new ArgumentException("Nome do endereço não pode ser vazio ou nulo.", nameof(nomeEndereco));
            }
            NomeEndereco = nomeEndereco;
        }
        public void SetCEP(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
            {
                throw new ArgumentException("CEP não pode ser vazio ou nulo.", nameof(cep));
            }
            CEP = cep;
        }
        public void SetEstado(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
            {
                throw new ArgumentException("Estado não pode ser vazio ou nulo.", nameof(estado));
            }
            Estado = estado;
        }


        public void SetCidade(string cidade)
        {
            if (string.IsNullOrWhiteSpace(cidade))
            {
                throw new ArgumentException("Cidade não pode ser vazio ou nulo.", nameof(cidade));
            }
            Cidade = cidade;
        }

        public void SetBairro(string bairro)
        {
            if (string.IsNullOrWhiteSpace(bairro))
            {
                throw new ArgumentException("Bairro não pode ser vazio ou nulo.", nameof(bairro));
            }
            Bairro = bairro;
        }
        public void SetEndereco(string endereco)
        {
            if (string.IsNullOrWhiteSpace(endereco))
            {
                throw new ArgumentException("Endereço não pode ser vazio ou nulo.", nameof(endereco));
            }
            Endereco = endereco;
        }
        public void SetNumero(string? numero)
        {
            Numero = numero;
        }
        public void SetComplemento(string? complemento)
        {
            Complemento = complemento;
        }

        private void IncluirEnderecoEntrega(int usuarioId, string nomeEndereco, string cep, string estado, string cidade, string bairro, string endereco, string? numero, string? complemento, Usuario usuario)
        {
            if (usuarioId < 0) throw new ArgumentException("Id de usuário inválido", nameof(usuarioId));
            SetUsuarioId(usuarioId);
            SetNomeEndereco(nomeEndereco);
            SetCEP(cep);
            SetEstado(estado);
            SetCidade(cidade);
            SetBairro(bairro);
            SetEndereco(endereco);
            SetNumero(numero);
            SetComplemento(complemento);
            SetUsuario(usuario);
        }

        private void UpdateEnderecoEntrega(int id, int usuarioId, string nomeEndereco, string cep, string estado, string cidade, string bairro, string endereco, string? numero, string? complemento, Usuario usuario)
        {
            if (id < 0) throw new ArgumentException("Id inválido", nameof(id));
            if (usuarioId < 0) throw new ArgumentException("Id de usuário inválido", nameof(usuarioId));
            SetUsuarioId(usuarioId);
            SetNomeEndereco(nomeEndereco);
            SetCEP(cep);
            SetEstado(estado);
            SetCidade(cidade);
            SetBairro(bairro);
            SetEndereco(endereco);
            SetNumero(numero);
            SetComplemento(complemento);
            SetUsuario(usuario);
        }

    }
}
