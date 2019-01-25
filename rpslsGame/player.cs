using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Player //(is a)
    {   // get player name
        // get player gesture
        // member variables (has a)
        String gesture;
        int score;
        string name;

        // construstor (spawner)

        // member methods (can do)
        public virtual void ChooseGesture()
        {
            string gesture = "rock, paper, scissors, lizard, spock";
           
        }

        public void ChooseName();
  

    }
           
}
