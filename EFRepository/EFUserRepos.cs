using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighScore;

namespace EFRepository 
{
    class EFUserRepos : EFRepos<User>, IUserRepos
    {
        EFUserRepos(HighScoreDbContext ctx) : base(ctx) { }

        public IEnumerable<TotalScore> GetTotalScores()
        {
            return ctx.user.Select(u => new TotalScore { User = u, TotalPoints = u.Scores.Sum(s => s.Points) }).OrderByDescending(i => i.TotalPoints).ToList();
        }

    }
}
