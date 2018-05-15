using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    static public class Converter
    {
        static public Common.Game ToDTO(this HighScore.Game game)
        {
            return new Common.Game { ID = game.ID, Name = game.Name };
        }
        static public Common.User ToDTO(this HighScore.User user)
        {
            return new Common.User { ID = user.ID, Name = user.Name };
        }
        static public Common.Score ToDTO(this HighScore.Score score)
        {
            return new Common.Score { ID = score.ID, Points = score.Points };
        }
        static public Common.TotalScore ToDTO(this HighScore.TotalScore totalScore)
        {
            return new Common.TotalScore { TotalPoints = totalScore.TotalPoints, user = totalScore.User.ToDTO() };
        }
        static public HighScore.Game ToPOCO(this Common.Game game)
        {
            return new HighScore.Game { ID = game.ID, Name = game.Name };
        }
        static public HighScore.User ToPOCO(this Common.User user)
        {
            return new HighScore.User { ID = user.ID, Name = user.Name };
        }
        static public HighScore.Score ToPOCO(this Common.Score score)
        {
            return new HighScore.Score { ID = score.ID, Points = score.Points };
        }
        static public HighScore.TotalScore ToPOCO(this Common.TotalScore totalScore)
        {
            return new HighScore.TotalScore { TotalPoints = totalScore.TotalPoints, User = totalScore.user.ToPOCO() };
        }
    }
}
