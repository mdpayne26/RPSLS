using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Comp : Player
    {
        //Random rnd;
        public Comp()
        {
             
        }
        //choose gesture
        public override void SetGestureChoice()
        {
            //random generator for gestures
            Random random = new Random();
            gestureChoice = random.Next(0, 4);
        }
        public override void GetPlayerName()
        {
            name = "Computer";
        }
    }
}

