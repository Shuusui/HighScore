using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using HighScore;

namespace Server
{
    class HighScoreService<TEntity> : IService where TEntity: IControllerFactory, new()
    {
        private HighScoreController controller = new TEntity().Produce();

        public HighScoreService() { }

        public Common.Game CreateGame(string name)
        {
            return controller.CreateGame(name).ToDTO();
        }

        public Common.Score CreateScore(int points, Common.Game game, Common.User user)
        {
            return controller.CreateScore(points, game.ToPOCO(), user.ToPOCO()).ToDTO();
        }

        public Common.User CreateUser(string name)
        {
            return controller.CreateUser(name).ToDTO();
        }

        public IEnumerable<Common.Game> GetGames()
        {
            return controller.GetGames().Select(g => g.ToDTO());
        }

        public IEnumerable<Common.Score> GetScoresPerGame(Common.Game game)
        {
            return controller.GetScoresPerGame(game.ToPOCO()).Select(s => s.ToDTO());
        }

        public IEnumerable<Common.Score> GetScoresPerUser(Common.User user)
        {
            return controller.GetScoresPerUser(user.ToPOCO()).Select(u => u.ToDTO());
        }

        public IEnumerable<Common.TotalScore> GetTotalScores()
        {
            return controller.GetTotalScores().Select(ts => ts.ToDTO());
        }

        public IEnumerable<Common.User> GetUsers()
        {
            return controller.GetUsers().Select(u => u.ToDTO());
        }
    }
}
