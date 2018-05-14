using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScore
{
    public class Game
    {
        public Game() { }
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Score> Scores { get; set; }
    }
}
