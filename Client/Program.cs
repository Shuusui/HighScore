using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Common;
using System.ServiceModel.Channels;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (HighscoreService service = new HighscoreService())
            {
                
                var games = service.GetGames();
                var users = service.GetUsers();
                foreach (Game game in games)
                    Console.WriteLine(game.Name);
                foreach (User user in users)
                    Console.WriteLine(user.Name);

                Console.ReadKey();
                
            }
        }
    }
}
