using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HighScore
{
    class HighScoreInitializer : DropCreateDatabaseIfModelChanges<HighScoreDbContext>
    {
        protected override void Seed(HighScoreDbContext context)
        {
            base.Seed(context);
            User user0 = new User { Name = "SexyHexi" };
            User user1 = new User { Name = "Shuusui" };
            User user2 = new User { Name = "HERBEERRT" };
            User user3 = new User { Name = "HUrensohn Mc Hurensohn" };

            context.user.Add(user0);
            context.user.Add(user1);
            context.user.Add(user2);
            context.user.Add(user3);


            Game game0 = new Game { Name = "HurenSohn Mc Hurensohn Game" };
            Game game1 = new Game { Name = "Dark Souls" };
            
            context.game.Add(game0);
            context.game.Add(game1);

            Score score0 = new Score { Game = game0, User = user1, Points = 9001 };
            Score score1 = new Score { Game = game1, User = user1, Points = 9001 };
            Score score2 = new Score { Game = game0, User = user0, Points = 9000 };
            Score score3 = new Score { Game = game1, User = user0, Points = 9000 };

            context.score.Add(score0);
            context.score.Add(score1);
            context.score.Add(score2);
            context.score.Add(score3);

            context.SaveChanges();
        }
    }
}
