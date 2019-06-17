using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class User : Player
    {
        //choose gesture

        public override void ChooseGesture()
        {
            Console.WriteLine("Please enter your gesture: ");
            Gesture = Int32.Parse(Console.ReadLine());
        }

        //playerOne = new User();
        public override void GetPlayerName()
        {
            Console.WriteLine("Player please enter your name: ");
            name = Console.ReadLine();
        }
    }
}
