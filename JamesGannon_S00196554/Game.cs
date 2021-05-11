using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesGannon_S00196554
{
    public class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public decimal MetacriticScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }

        public void DecreasePrice(decimal discount)
        {
            Price -= discount;
        }
    }//end of class

    public class GameData:DbContext
    {
        public GameData() : base("Game Details") { }//Name database
        public DbSet<Game> Games { get; set; }//Create Games table
    }
}
