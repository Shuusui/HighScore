﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighScore;
using EFRepository;
namespace Server
{
    public class ControllerFactory : IControllerFactory
    {
        
        public HighScoreController Produce()
        {
            return new HighScoreController(new EFSessionScope());
        }
    }
}
