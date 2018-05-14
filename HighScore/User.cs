using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScore
{
    public class User
    {
        public User() { }
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Score> Scores { get; set; }

        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                return false;
            }
            if (obj is User)
            {
                User user = (User)obj;
                if (user.ID == this.ID)
                    return true;

                return false;
            }
            return false; 
        }
    }
}
