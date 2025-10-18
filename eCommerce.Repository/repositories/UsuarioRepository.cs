using eCommerce.Models;
using eCommerce.Models.interfaces;
using eCommerce.Repository.context;
using Microsoft.EntityFrameworkCore;


namespace eCommerce.Repository.repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ECommerceContext _db;
        public UsuarioRepository(ECommerceContext db)
        {
            _db = db;
        }
        public async Task<IList<Usuario>> Get()
        {

            return await _db.Usuarios.ToListAsync();
        }

        public async Task<Usuario?> GetById(int id)
        {
            return await _db.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
        }
        public Task<Usuario> Add(Usuario usuario)
        {
            _db.Add(usuario);
            _db.SaveChanges();
            return Task.FromResult(usuario);
        }
        public Task<Usuario> Update(Usuario usuario)
        {
            _db.Usuarios.Update(usuario);
            _db.SaveChanges();
            return Task.FromResult(usuario);
        }
        public async Task<bool> Delete(int id)
        {
            var usuario = await GetById(id);
            if (usuario == null) return false;
            _db.Usuarios.Remove(usuario);
            return await _db.SaveChangesAsync() > 0;
        }




    }
}
