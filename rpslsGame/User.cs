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

        public override void SetGestureChoice()
        {
            Console.WriteLine("{0}, input the number to make your weapon selection" +
                "\n1. rock \n2. paper \n3. scissors \n4. spock \n5. lizard", name);
            try
            {
                gestureChoice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                if (gestureChoice < 1 || gestureChoice > 5)
                {
                    Console.WriteLine("Not a valid choice!");
                    SetGestureChoice();
                }
            }
        }

        //playerOne = new User();
        public override void GetPlayerName()
        {
            Console.WriteLine("Player please enter your name: ");
            name = Console.ReadLine();
        }
    }
}
