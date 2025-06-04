namespace TicTacToe.Domain.Entities
{
    public class User
    {
        public User(string name)
        {
            Name = name;
        }
        
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}