using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models.interfaces
{
    public interface IUsuarioRepository
    {
        public Task<IList<Usuario>> Get();
        public Task<Usuario?> GetById(int id);
        public Task<Usuario> Add(Usuario usuario);
        public Task<Usuario> Update(Usuario usuario);
        public Task<bool> Delete(int id);
    }
}
