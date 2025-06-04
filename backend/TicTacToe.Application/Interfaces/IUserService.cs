using TicTacToe.Domain.Entities;

namespace TicTacToe.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<string> GetAllUserNames();

        User Create(string name);

        User? Get(string name); 
    }
}