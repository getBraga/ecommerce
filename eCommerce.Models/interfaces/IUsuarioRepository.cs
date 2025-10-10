using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models.interfaces
{
    public interface IUsuarioRepository
    {
        public IList<Usuario> Get();
        public Usuario? GetById(int id);
        public Usuario Add(Usuario usuario);
        public Usuario Update(Usuario usuario);
        public bool Delete(int id);
    }
}
