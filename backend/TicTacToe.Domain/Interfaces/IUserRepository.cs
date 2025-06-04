using TicTacToe.Domain.Entities;

namespace TicTacToe.Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User Create(string name);

        User? Get(string name);
    }
    
}