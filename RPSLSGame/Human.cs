using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Human:Player
    {
        //member variables
        

        //constructor
        public Human(string name)
        {
            this.name = name;
        }

        //methods
        public override int GetPlayer2Choice(Display display, Player player)
        {

            int i = display.ShowGestureOptions(player);
            return i;
        }
    }
}
