using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighScore;

namespace EFRepository
{
    class EFScoreRepso : EFRepos<Score>, IScoreRepos
    {
        EFScoreRepso(HighScoreDbContext ctx) : base(ctx) { }

        public IEnumerable<Score> GetScoresPerUser(User user)
        {
            user = ctx.user.Find(user.ID);
            ctx.Entry(user).Collection(u => u.Scores).Load();
            return user.Scores.ToList();
            
        }
        public IEnumerable<Score> GetScoresPerGame(Game game)
        {
           return game.Scores;         
        }

    }
}
