using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScore
{
    public interface ISessionScope : IDisposable 
    {
        IGameRepos GameRepos { get;  }
        IScoreRepos ScoreRepos { get; }
        IUserRepos UserRepos { get; }

        void Save();
    }
}
