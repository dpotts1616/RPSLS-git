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
            display.DisplayWelcomeScreen();
            ChooseOpponent();
            ChooseSeriesLength();
            do
            {
                Console.Clear();
                ChooseGestureList(player1);
                Gesture opponentGesture = GetPlayer2Gesture(player2, display);
                int compare = CompareGestures(player1, opponentGesture);
                display.DeclareRoundWinner(compare, player1, player2);
                ShowScore(player1, player2);
                player1.ResetBoard();
            } while (player1.score < (seriesLength / 2) && player2.score < (seriesLength / 2));

            display.DeclareGameWinner(player1, player2);
        }


        //Setup
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

        public void ChooseSeriesLength()
        {
            seriesLength = display.ChooseSeriesLength();
        }


        //Gameplay
        public void ChooseGestureList(Player player)
        {
            int choice = display.ShowGestureOptions(player);
            player.CreateGestureList(choice);
        }

        public Gesture GetPlayer2Gesture(Player player2, Display display)
        {
            int choice = player2.GetPlayer2Choice(display, player2);
            Gesture gesture = player2.gestures[choice - 1];
            return gesture;
        }

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
        public void ShowScore(Player player1, Player player2)
        {
            if (player1.score < (seriesLength/2) && player2.score < (seriesLength/2))
            {
                display.ShowScore(player1, player2);
                Console.ReadLine();
            }
        }
    }
}
