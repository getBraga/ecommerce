using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Dtos
{
    public class UsuarioDto
    {
        public int Id { get;  set; }
        public string Nome { get;  set; } = string.Empty;
        public string Email { get;  set; } = string.Empty;
        public string Sexo { get;  set; } = string.Empty;
        public string RG { get;  set; } = string.Empty;
        public string CPF { get;  set; } = string.Empty;
        public string NomeMae { get;  set; } = string.Empty;
        public string SituacaoCadastro { get;  set; } = string.Empty;
        public DateTimeOffset DataCadastro { get;  set; }
    }
}
