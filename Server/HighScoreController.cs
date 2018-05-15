using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScore
{
    public class HighScoreController
    {
        private ISessionScope sessionScope;

        public HighScoreController(ISessionScope sessionScope)
        {
            this.sessionScope = sessionScope;
        }


        public User CreateUser(string name)
        {
            var user = new User { Name = name };
            user = sessionScope.UserRepos.Create(user);
            sessionScope.Save();
            return user;
        }

        public Game CreateGame(string name)
        {
            var game = new Game { Name = name };
            sessionScope.GameRepos.Create(game);
            sessionScope.Save();
            return game;
        }

        public Score CreateScore(int points, Game game, User user)
        {
            var score = new Score { Points = points, Game = game, User = user };
            sessionScope.ScoreRepos.Create(score);
            sessionScope.Save();
            return score;
        }

        public IEnumerable<Game> GetGames()
        {
            return sessionScope.GameRepos.GetAll();
        }

        public IEnumerable<User> GetUsers()
        {
            return sessionScope.UserRepos.GetAll();
        }

        public IEnumerable<Score> GetScoresPerGame(Game game)
        {
            return sessionScope.ScoreRepos.GetScoresPerGame(game);
        }

        public IEnumerable<Score> GetScoresPerUser(User user)
        {
            return sessionScope.ScoreRepos.GetScoresPerUser(user);
        }
        
        public IEnumerable<TotalScore> GetTotalScores()
        {
            return sessionScope.UserRepos.GetTotalScores();
        }

    }
}
