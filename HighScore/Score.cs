using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScore
{
    public class Score 
    {
        public Score() { }
        public int ID { get; set; }
        public int Points { get; set; }
        public Game Game { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }
    }
}
