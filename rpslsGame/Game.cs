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
        public Player playerOne;
        public Player playerTwo;
        public void GetPlayers()
        {
            Console.WriteLine(" Single player or two players? Press 1 for single player or press 2 for two players");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                playerOne = new User();             
                playerTwo = new Comp();
            }
            else if(userInput == "2")
            {
                playerOne = new User();
                playerTwo = new User();
            }
            
        }
        public void SetPlayerNames()
        {
            playerOne.GetPlayerName();
            playerTwo.GetPlayerName();
            Console.Clear();
        }
        public void listWeapons()
        {

            Console.WriteLine("Rock = 0\n");
            Console.WriteLine("Paper = 1\n");
            Console.WriteLine("Scissors = 2\n");
            Console.WriteLine("Lizard = 3\n");
            Console.WriteLine("Spock = 4\n");
        }
        public void Battle()
        {
            //switch case
        }
        public void DisplayRules()
        {
            Console.WriteLine("Display rules\n ");
            Console.WriteLine("Scissors cuts paper. Paper covers rock. Rock crushes lizard." +
                " Lizard poisons Spock. Spock smashes scissors, scissors decapitates lizard." +
                " Lizard eats paper, paper disproves Spock. Spock vaporizes rock. And, as it always has," +
                " rock crushes scissors.﻿");
        }
        public void SetPlayerGesture()
        {
            playerOne.SetGestureChoice();
            DisplayChoice(playerOne);
            playerTwo.SetGestureChoice();
            DisplayChoice(playerTwo);
        }
        public void DisplayChoice(Player player)
        {
            switch (player.gestureChoice)
            {
                case 1:
                    Console.WriteLine("{0} chooses rock", player.name);
                    break;
                case 2:
                    Console.WriteLine("{0} chooses paper", player.name);
                    break;
                case 3:
                    Console.WriteLine("{0} chooses scissors", player.name);
                    break;
                case 4:
                    Console.WriteLine("{0} chooses spock", player.name);
                    break;
                case 5:
                    Console.WriteLine("{0} chooses lizard", player.name);
                    break;
            }
        }
        public void RunGame()
        {
            GetPlayers();
            //PlayerOne.GetPlayerName();
            //PlayerTwo.GetPlayerName();
            DisplayRules();


           



            //List<string> Gestures = new List<string>();
            //Gestures.Add("Rock");
            //Gestures.Add("Paper");
            //Gestures.Add("scissors");
            //Gestures.Add("Lizard");
            //Gestures.Add("Spock");

            //listWeapons();

            //PlayerOne.SetGestureChoice();
            //Console.WriteLine(PlayerOne.name + " chose " + PlayerOne.Gesture);
            //Console.ReadLine();
            //PlayerTwo.SetGestureChoice();
            //Console.WriteLine(PlayerTwo.name + " chose " + PlayerTwo.Gesture);
            //Console.ReadLine();
            

            //compare gestures
            

            //determine round winner 
            //-increment counter
            //checked if game winner
            //-if not game winner repeat steps
            //--if game winner ask play again?
        }


    }
}
    

