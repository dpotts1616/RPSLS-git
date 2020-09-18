using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class AI:Player
    {
        //member variables

        //constructor
        public AI()
        {
            this.name = "Computer";
        }

        //methods
        public override int GetPlayer2Choice(Display display, Player player)
        {
            Random rand = new Random();
            int i = rand.Next(0, 6);
            return i;
        }
    }
}
