using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScore
{
    public class HighScoreController
    {
        private IGameRepos gameRepos;
        private IScoreRepos scoreRepos;
        private IUserRepos userRepos;

        public HighScoreController(IGameRepos gameRepos, IUserRepos userRepos, IScoreRepos scoreRepos)
        {
            this.gameRepos = gameRepos;
            this.scoreRepos = scoreRepos;
            this.userRepos = userRepos; 
        }


        public User CreateUser(string name)
        {
            var user = new User { Name = name };
            return user = userRepos.Create(user);            
        }

        public Game CreateGame(string name)
        {
            var game = new Game { Name = name };
            return gameRepos.Create(game);
        }

        public Score CreateScore(int points, Game game, User user)
        {
            var score = new Score { Points = points, Game = game, User = user };
            return scoreRepos.Create(score);
        }

        public IEnumerable<Game> GetGames()
        {
            return gameRepos.GetAll();
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepos.GetAll();
        }

        public IEnumerable<Score> GetScoresPerGame(Game game)
        {
            return scoreRepos.GetScoresPerGame(game);
        }

        public IEnumerable<Score> GetScoresPerUser(User user)
        {
            return scoreRepos.GetScoresPerUser(user);
        }
        
        public IEnumerable<TotalScore> GetTotalScores()
        {
            return userRepos.GetTotalScores();
        }

    }
}
