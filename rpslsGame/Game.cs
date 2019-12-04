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
        public void DisplayRules()
        {
            Console.WriteLine("Display rules\n ");
            Console.WriteLine("Scissors cuts paper. Paper covers rock. Rock crushes lizard." +
                " Lizard poisons Spock. Spock smashes scissors, scissors decapitates lizard." +
                " Lizard eats paper, paper disproves Spock. Spock vaporizes rock. And, as it always has," +
                " rock crushes scissors.﻿");
        }
        // display players choice
        public void SetPlayerGesture()
        {
            playerOne.SetGestureChoice();
            DisplayChoice(playerOne);
            playerTwo.SetGestureChoice();
            DisplayChoice(playerTwo);
        }
        // get player choice
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
        public int CalculateWinner()
        {
            int multiplier = 5;
            int roundResult = (multiplier + playerOne.gestureChoice - playerTwo.gestureChoice) % multiplier;
            return roundResult;
        }
        public void CheckWinner(int roundResult)
        {
            if(roundResult ==1 || roundResult == 3)
            {
                Console.WriteLine("{0} wins the round!\n", playerOne.name);
                IncrementScore(playerOne);
            }
            else if (roundResult == 2|| roundResult == 4)
            {
                Console.WriteLine("{0} wins the round!\n", playerTwo.name);
                IncrementScore(playerTwo);
            }
            else if (roundResult == 0)
            {
                Console.WriteLine("its a tie");
            }
        }
        public void IncrementScore(Player player)
        {
            player.score++;
        }
        public void CheckWinner()
        {
            if(playerOne.score == 2)
            {
                Console.WriteLine("{0} wins the game!\n", playerOne.name);
            }
            else if(playerTwo.score == 2)
            {
                Console.WriteLine("{0} wins the game!|n", playerTwo.name);
            }
        }
        public void RunGame()
        {
            GetPlayers();
            SetPlayerNames();
            DisplayRules();
            SetPlayerGesture();
            CalculateWinner();
            CheckWinner();
           
            
            

            //determine round winner 
            //-increment counter
            //checked if game winner
            //-if not game winner repeat steps
            //--if game winner ask play again?
        }


    }
}
    

