using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Comp : Player
    {
        Random rnd;
        public Comp()
        {
             rnd = new Random();
            
        }
        //public string Gesture[] = new string[5] { "Rock", "Paper", "scissors", "Lizard", "Spock"}
        //choose gesture
        public override void ChooseGesture()
        {
            //random generator for gestures
           
            Console.WriteLine(rnd.Next(5));
            Console.WriteLine(rnd.Next(5));
            Console.WriteLine(rnd.Next(5));
            //return Gesture;
            //string result = Gesture[randomNumber];
            //return result;
            //int compGesture = Gesture[randomNumber];
        }
        public override void GetPlayerName()
        {
            Console.WriteLine("Computer name: ");
            name = Console.ReadLine();
        }

        
    }
}

