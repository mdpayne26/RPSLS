using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Comp :Player
    {

        //choose gesture
        public override void ChooseGesture()
        {
            //random generator for gestures
            Random random = new Random();
            int randomNumber = random.Next(0, 4);
        }
        public override void GetPlayerName()
        {
            Console.WriteLine("Computer");
            name = Console.ReadLine();
        }
    }
}

