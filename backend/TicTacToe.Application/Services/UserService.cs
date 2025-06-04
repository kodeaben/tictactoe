using TicTacToe.Application.Interfaces;
using TicTacToe.Domain.Entities;
using TicTacToe.Domain.Interfaces;

namespace TicTacToe.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<string> GetAllUserNames()
        {
            return _repository.GetAll().Select(x => x.Name).ToList();
        }

        public User Create(string name)
        {
            var user = _repository.Get(name);
            if (user != null)
            {
                throw new Exception("User already exist");
            }

            return _repository.Create(name);
        }

        public User? Get(string name)
        {
            return _repository.Get(name);
        }
    }
}