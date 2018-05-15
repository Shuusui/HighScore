using System;
using System.Linq;
using EFRepository;
using Server;

namespace HighScore
{
    class Program
    {
        static void Main(string[] args)
        {

            using (Host<ControllerFactory> Host = new Host<ControllerFactory>())
            {
                Host.StartServer();
            }
        }
    }
}
