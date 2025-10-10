using eCommerce.Models;
using eCommerce.Models.interfaces;


namespace eCommerce.Repository.repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly static List<Usuario> _db = [];
        public IList<Usuario> Get()
        {
            return _db;
        }

        public Usuario? GetById(int id)
        {
            return _db.FirstOrDefault(u => u.Id == id);
        }
        public Usuario Add(Usuario usuario)
        {
            _db.Add(usuario);
            return usuario;
        }
        public Usuario Update(Usuario usuario)
        {
            _db.Remove(usuario);
            _db.Add(usuario);
            return usuario;
        }
        public bool Delete(int id)
        {
            var usuario = GetById(id);
            if (usuario == null) return false;
            _db.Remove(usuario);

            return true;
        }




    }
}
