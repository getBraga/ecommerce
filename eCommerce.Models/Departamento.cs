using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Departamento
    {
        public int Id { get; private set; }
        public string Nome { get; private set; } = null!;
        public ICollection<Usuario>? Usuarios { get; private set; }

        protected Departamento()
        {
       
        }
        public static Departamento CriarDepartamento(string nome, ICollection<Usuario>? usuarios)
        {
            var departamento = new Departamento();
            departamento.IncluirNovoDepartamento(nome, usuarios);
            return departamento;
        }
        public  void AtualizarDepartamento(int id, string nome, ICollection<Usuario>? usuarios)
        {
          
            UpdateDepartamento(id, nome, usuarios);
        }
        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Nome do departamento não pode ser vazio ou nulo.", nameof(nome));
            }
            Nome = nome;
        }
        public void SetUsuarios(ICollection<Usuario>? usuarios)
        {
            Usuarios = usuarios;
        }
        private void IncluirNovoDepartamento(string nome, ICollection<Usuario>? usuarios)
        {
            SetNome(nome);
            SetUsuarios(usuarios);
        }
        private void UpdateDepartamento(int id, string nome, ICollection<Usuario>? usuarios)
        {
            if (id < 0) throw new ArgumentException("Id inválido", nameof(id));
            Id = id;
            SetNome(nome);
            SetUsuarios(usuarios);
        }
    }
}
