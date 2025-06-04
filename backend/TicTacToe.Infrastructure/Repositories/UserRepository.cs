using TicTacToe.Domain.Entities;
using TicTacToe.Domain.Interfaces;
using TicTacToe.Infrastructure.Data;

namespace TicTacToe.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public User Create(string name)
        {
            User newUser = new User(name);
            try
            {
                _context.Users.Add(newUser);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return newUser;
        }

        public User? Get(string name)
        {
            var user = _context.Users.FirstOrDefault(y => y.Name == name);
            return user;
        }
    }
}