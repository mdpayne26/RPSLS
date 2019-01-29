using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Game
    {
        //display rules
       
        //get player names



        //choose game mode(comp or user)
         Player PlayerOne;
         Player PlayerTwo;


        public void GetPlayers()
        {
            Console.WriteLine(" 1 or 2 Players?");
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
        //compare gestures
        //determine round winner 
        //-increment counter
        //checked if game winner
        //-if not game winner repeat steps
        //--if game winner ask play again?
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
            Console.WriteLine("Display rules\n ");
            Console.WriteLine("Scissors cuts paper. Paper covers rock. Rock crushes lizard." +
                " Lizard poisons Spock. Spock smashes scissors, scissors decapitates lizard." +
                " Lizard eats paper, paper disproves Spock. Spock vaporizes rock. And, as it always has," +
                " rock crushes scissors.﻿");

            GetPlayers();


            PlayerOne.GetPlayerName();
            PlayerTwo.GetPlayerName();
            
            List<string> Gestures = new List<string>();
            Gestures.Add("Rock");
            Gestures.Add("Paper");
            Gestures.Add("scissors");
            Gestures.Add("Lizard");
            Gestures.Add("Spock");

            listWeapons();

            PlayerOne.ChooseGesture();
            PlayerTwo.ChooseGesture();
            Console.WriteLine(PlayerOne.name + " picked " + Gestures(PlayerOne.Gesture));
            Console.ReadLine();
        }

        
    }
}
    

