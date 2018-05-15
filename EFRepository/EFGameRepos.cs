﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighScore;

namespace EFRepository
{
    public class EFGameRepos :EFRepos<Game>, IGameRepos
    {
        public EFGameRepos(HighScoreDbContext ctx) : base(ctx) { }

    }
}
