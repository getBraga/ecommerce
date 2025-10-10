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
        public string? NomeEndereco { get; private set; }
        public string? CEP { get; private set; }
        public string? Estado { get; private set; }
        public string? Cidade { get; private set; }
        public string? Bairro { get; private set; }
        public string? Endereco { get; private set; }
        public string? Numero { get; private set; }
        public string? Complemento { get; private set; }
        public Usuario? Usuario { get; private set; } 

    }
}
