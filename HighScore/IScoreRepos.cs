using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighScore;

namespace HighScore
{
    public interface IScoreRepos : IRepository<Score>
    {
        IEnumerable<Score> GetScoresPerUser(User user);

        IEnumerable<Score> GetScoresPerGame(Game game);
    }
}
