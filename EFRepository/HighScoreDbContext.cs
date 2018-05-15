using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace HighScore
{
    public class HighScoreDbContext :DbContext
    {
        static HighScoreDbContext()
        {
            Database.SetInitializer<HighScoreDbContext>(new HighScoreInitializer());
        }
        public HighScoreDbContext() :base() { }

        public DbSet<Game> game { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<Score> score { get; set; }
    }
}
