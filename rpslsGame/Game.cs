using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Game // (is a)
    {   // display rules
        //compare gestures
        //determin winner
        //check if game winner


        // member variables (has a)
        public Player playerOne;
        public Player playerTwo;
        // construstor (spawner)

        // member methods (can do)


        private void GetPlayers()
        {
            Console.WriteLine("One or Two players");
            string userInput = (Console.ReadLine());
            if (userInput == "1") 
            {
                playerOne = new UserPlayer();
                playerTwo = new CompPlayer();
            }
            else if (userInput == "2") 
            {
                playerOne = new UserPlayer();
                playerTwo = new UserPlayer();
            }
        }


        public void RunGame()
        {
            Console.WriteLine("Scissors cuts Paper and decapitate Lizard, Paper covers Rock and disproves Spock, Rock crushes Lizard and Scissors," +
           " Lizard poisons Spock and eats Paper, Spock vaporizes Rock and smashes Scissors.");
            GetPlayers();
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
        }


    


    public void GestureList()

    {
       // Console.WriteLine("please choose your weapon \n");
       // Console.WriteLine("Press [1] to use rock.");
       // Console.WriteLine("Press [2] to use scissors.");
       // Console.WriteLine("Press [3] to use paper.");
       // Console.WriteLine("Press [4] to use lizzard.");
       // Console.WriteLine("Press [5] to use spock.\n");
        
       // string userInput = Console.ReadLine();

       // switch ("1") // userinput
       // {
       //     case "scissors":
       //         Console.WriteLine("Sorry but your scissors were crushed by a rock.");
       //         break;
       //     case "lizzard":
       //         Console.WriteLine("Sorry but your lizzard was crushed by a rock.");
       //         break;
       //     default:
       //         Console.WriteLine("Not a valid choice");
       //         break;
       // }
       // switch ("2")
       // {
       //     case "paper":
       //         Console.WriteLine("Sorry but your paper was cut by scissors.");
       //         break;
       //     case "lizzard":
       //         Console.WriteLine("Sorry but your lizzard was decapitated by scissors.");
       //         break;
       //     default:
       //         Console.WriteLine("Not a valid choice");
       //         break;
       // }
       //switch ("3")
       // { 
       //     case "rock":
       //         Console.WriteLine("Sorry but your rock was covered by paper.");
       //         break;
       //     case "spock":
       //         Console.WriteLine("Sorry but your spock was disproved by paper.");
       //         break;
       //     default:
       //         Console.WriteLine("Not a valid choice");
       //         break;
       // }
       // switch ("4")
       // { 
       //     case "spock":
       //         Console.WriteLine("Sorry but your spock was poisoned by a lizzard.");
       //         break;
       //     case "paper":
       //         Console.WriteLine("Sorry but your paper was eatten by a lizzard.");
       //         break;
       //     default:
       //         Console.WriteLine("Not a valid choice");
       //         break;
       // }
       // switch ("5")
       // {
       //     case "scissors":
       //         Console.WriteLine("Sorry but you scissors were smashed by spock.");
       //         break;
       //     case "rock":
       //         Console.WriteLine("Sorry but your rock was vaporizes by spock.");
       //         break;
       //     default:
       //         Console.WriteLine("Not a valid choice");
       //         break;
       // }


    }
    }
}
