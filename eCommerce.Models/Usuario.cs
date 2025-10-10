using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string? Sexo { get; private set; }
        public string RG { get; private set; } = null!;
        public string CPF { get; private set; } = null!;
        public string? NomeMae { get; private set; } 
        public string? SituacaoCadastro { get; private set; } 
        public DateTimeOffset DataCadastro { get; private set; }
        public Contato? ContatoUsuario { get; private set; }
        public ICollection<EnderecoEntrega>? EnderecosEntrega { get; private set; }
        public ICollection<Departamento>? Departamentos { get; private set; }

       
        public void CriarUsuario(
    string nome,
    string email,
    string sexo,
    string rg,
    string cpf,
    string nomeMae,
    string situacaoCadastro

)
        {
            Nome = nome;
            Email = email;
            Sexo = sexo;
            RG = rg;
            CPF = cpf;
            NomeMae = nomeMae;
            SituacaoCadastro = situacaoCadastro;
          
        }

        public void AtualizarUsuario(
     int id,
    string nome,
    string email,
    string sexo,
    string rg,
    string cpf,
    string nomeMae,
    string situacaoCadastro

)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            RG = rg;
            CPF = cpf;
            NomeMae = nomeMae;
            SituacaoCadastro = situacaoCadastro;

        }
    }


}
