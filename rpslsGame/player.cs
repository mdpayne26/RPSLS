using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    public abstract class Player 
    {
        public int gestureChoice;
        public int score;
        public string name;

        

        public abstract void SetGestureChoice();
        
        public abstract void GetPlayerName();







    }

}
