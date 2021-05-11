using System.Data.Entity;

namespace KonradSzpak_S00197298_FinalExam2
{
    public class Game
    {
        public string Name { get; set; }
        public int CriticScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }

        public Game()
        {
        }
        public Game(string name, int metacriticScore, string description, string platform, decimal price, string gameImage)
        {
            Name = name;
            CriticScore = metacriticScore;
            Description = description;
            Platform = platform;
            Price = price;
            GameImage = gameImage;
        }
        public override string ToString()
        {
            return Name;

        }
        public void DecreasePrice(double decrease)
        {
            Price *= (decimal)(1 - decrease);
        }

       
    }
    public class GameData : DbContext
    {
        public GameData() : base("GameInfo") { }
        public DbSet<Game> Games { get; set; }
    }
}

