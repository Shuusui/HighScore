using System;
using System.Linq;
using EFRepository;

namespace HighScore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ISessionScope sessionScope = new EFSessionScope())
            {


                HighScoreController controller = new HighScoreController(sessionScope);

                controller.CreateUser("Sexy Hexi");
                controller.CreateUser("Hurensohn McHurenSohn");
                controller.CreateUser("Bastardo");
                controller.CreateUser("DEINNEEE MUDDA");
                controller.CreateGame("League of Legends");
                controller.CreateGame("Dark Souls");
                controller.CreateScore(9001, controller.GetGames().ElementAt(1), controller.GetUsers().ElementAt(0));
                controller.CreateScore(9000, controller.GetGames().ElementAt(1), controller.GetUsers().ElementAt(2));
                controller.CreateScore(350, controller.GetGames().ElementAt(0), controller.GetUsers().ElementAt(3));
                controller.CreateScore(401, controller.GetGames().ElementAt(0), controller.GetUsers().ElementAt(1));
                // GetGames->Test: Auflistung aller Spiele mit Namen und bestem Score
                foreach (Game game in controller.GetGames())
                {
                    Console.WriteLine(game.Name);

                    foreach (Score score in game.Scores)
                    {
                        Console.WriteLine(score.Points);
                    }
                }
                // GetScorePerUser->Test: Auflistung aller gespielten Speiele eines Users
                foreach (User user in controller.GetUsers())
                {
                    foreach (Score score in controller.GetScoresPerUser(user))
                    {
                        Console.WriteLine(score.Points);
                    }
                }
                // GetTotalScores->Test: Auflistung der zehn besten Spieler mit ihren Topscores
                foreach (TotalScore score in controller.GetTotalScores())
                {
                    Console.WriteLine("{0} : {1}", score.User.Name, score.TotalPoints);
                }
                Console.ReadKey();
            }

        }
    }
}
