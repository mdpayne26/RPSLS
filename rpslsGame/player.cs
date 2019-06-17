using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    public abstract class Player 
    {
        public int Gesture;
        public int score;
        public string name;

        

        public abstract void ChooseGesture();
        
        public abstract void GetPlayerName();







    }

}
