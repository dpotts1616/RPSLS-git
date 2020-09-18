using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Platform
    {
        //member variables
        public Player player1;
        public Player player2;
        public double seriesLength;
        public Display display;

        //constructor
        public Platform()
        {
            display = new Display();
            player1 = new Human("Player 1");

        }

        //methods
        //Run Game
        public void RunGame()
        {
            
            //display welcome screen and rules
            ChooseOpponent();
            ChooseSeriesLength();

            //loop for rounds
            do
            {
                ChooseGestureList(player1);
                //split between computer and human
                Gesture opponentGesture = GetPlayer2Choice(player2);
                int compare = CompareGestures(player1, opponentGesture);
                display.DeclareRoundWinner(compare, player1, player2);
                display.ShowScore(player1, player2);
                player1.ResetBoard();
            } while (player1.score < (seriesLength / 2) && player2.score < (seriesLength / 2));
            



        }


        //choose opponent
        public void ChooseOpponent()
        {
            int i = display.ChooseOpponent();
            player2 = CreateOpponent(i);
        }

        public Player CreateOpponent(int i)
        {
            if (i == 1)
            {
                Player player2 = new Human("Player 2");
                return player2;
            }
            else if (i == 2)
            {
                Player player2 = new AI();
                return player2;
            }
            return player2;
        }

        //choose series length
        public void ChooseSeriesLength()
        {
            seriesLength = display.ChooseSeriesLength();
        }

        //PLAY
        //choose/get gesture(player 1 and 2)
        public void ChooseGestureList(Player player)
        {
            int choice = display.ShowGestureOptions(player);
            player.CreateGestureList(choice);


        }

        public Gesture GetPlayer2Choice(Player player2)
        {
            int choice = display.ShowGestureOptions(player2);
            Gesture gesture = player2.gestures[choice-1];
            return gesture;
        }


        //Compare gestures
        public int CompareGestures(Player player1, Gesture gesture)
        {
            for(int i = 0; i < player1.gestureList.Count; i++)
            {
                if (gesture.name == player1.gestureList[i].name)
                {
                    return i;
                }
            }
            return 0;
        }


        //display round winner
        

        //Update series score
            //repeat

        //Display series winner

    }
}
