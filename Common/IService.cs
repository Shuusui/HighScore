using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Common
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        User CreateUser(string name);
        [OperationContract]
        Game CreateGame(string name);
        [OperationContract]
        Score CreateScore(int points, Game game, User user);
        [OperationContract]
        IEnumerable<Game> GetGames();
        [OperationContract]
        IEnumerable<User> GetUsers();
        [OperationContract]
        IEnumerable<Score> GetScoresPerGame(Game game);
        [OperationContract]
        IEnumerable<Score> GetScoresPerUser(User user);
        [OperationContract]
        IEnumerable<TotalScore> GetTotalScores(); 
    }
}
