using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighScore;

namespace EFRepository
{
    class EFGameRepos :EFRepos<Game>, IGameRepos
    {
        EFGameRepos(HighScoreDbContext ctx) : base(ctx) { }

    }
}
