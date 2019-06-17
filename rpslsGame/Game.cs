using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Game
    {
        //choose game mode(comp or user)
        Player PlayerOne;
        Player PlayerTwo;
        

        public void GetPlayers()
        {
            Console.WriteLine(" Single player or two players? Press 1 for single player or press 2 for two players");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                PlayerOne = new User();             
                PlayerTwo = new Comp();
            }
            else if(userInput == "2")
            {
                PlayerOne = new User();
                PlayerTwo = new User();
            }
        }
       
        public void listWeapons()
        {
            Console.WriteLine("Rock = 0\n");
            Console.WriteLine("Paper = 1\n");
            Console.WriteLine("Scissors = 2\n");
            Console.WriteLine("Lizard = 3\n");
            Console.WriteLine("Spock = 4\n");
        }

        public void RunGame()
        {
            GetPlayers();

            PlayerOne.GetPlayerName();
            PlayerTwo.GetPlayerName();


            //display rules
            Console.WriteLine("Display rules\n ");
            Console.WriteLine("Scissors cuts paper. Paper covers rock. Rock crushes lizard." +
                " Lizard poisons Spock. Spock smashes scissors, scissors decapitates lizard." +
                " Lizard eats paper, paper disproves Spock. Spock vaporizes rock. And, as it always has," +
                " rock crushes scissors.﻿");

            
            
            List<string> Gestures = new List<string>();
            Gestures.Add("Rock");
            Gestures.Add("Paper");
            Gestures.Add("scissors");
            Gestures.Add("Lizard");
            Gestures.Add("Spock");

            listWeapons();

            PlayerOne.ChooseGesture();
            Console.WriteLine(PlayerOne.name + " chose " + PlayerOne.Gesture);
            Console.ReadLine();
            PlayerTwo.ChooseGesture();
            Console.WriteLine(PlayerTwo.name + " chose " + PlayerTwo.Gesture);
            Console.ReadLine();
            

            //compare gestures
            

            //determine round winner 
            //-increment counter
            //checked if game winner
            //-if not game winner repeat steps
            //--if game winner ask play again?
        }


    }
}
    

