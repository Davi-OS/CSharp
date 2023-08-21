using Microsoft.EntityFrameworkCore;
using TaskSystem.Data;
using TaskSystem.Models;
using TaskSystem.Repository.Interfaces;

namespace TaskSystem.Repository
{
    public class UserRepo : IUserRepository
    {
        private readonly TaskDBContext _dbContext;
        public UserRepo(TaskDBContext SistemaTarefas)
        {
            _dbContext = SistemaTarefas;
        }

        public async Task<UserModel> BuscarPorId(int id)
        {
            
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id); 
        }

        public async Task<List<UserModel>> BuscaTodsUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }
        public async Task<UserModel> Add(UserModel user)
        {
            await _dbContext.Usuarios.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<UserModel> Update(UserModel user, int id)
        {
            UserModel usuario = await BuscarPorId(id);
            if (usuario == null)
            {
                throw new Exception($"Usuario de Id {id} não foi encontrado");
            }
            usuario.Name = user.Name;
            usuario.Email = user.Email;

            _dbContext.Usuarios.Update(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario;

        }

        public async Task<bool> Delete(int id)
        {
            UserModel usuario = await BuscarPorId(id);
            if (usuario == null)
            {
                throw new Exception($"Usuario de Id {id} não foi encontrado");
            }
            _dbContext.Usuarios.Remove(usuario);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
