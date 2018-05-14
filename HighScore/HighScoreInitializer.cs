using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HighScore
{
    class HighScoreInitializer : DropCreateDatabaseAlways<HighScoreDbContext>
    {
        protected override void Seed(HighScoreDbContext context)
        {
            base.Seed(context);
        }
    }
}
