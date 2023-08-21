using TaskSystem.Models;

namespace TaskSystem.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> BuscaTodsUsuarios();
        Task<UserModel> BuscarPorId(int id);
        Task<UserModel> Add (UserModel user);
        Task<UserModel> Update(UserModel user, int id);
        Task<bool> Delete(int id);
    }
}
