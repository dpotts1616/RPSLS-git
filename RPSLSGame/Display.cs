using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Display
    {
        //member variables

        //constructor

        //methods
        public int ChooseOpponent()
        {
            bool check = false;
            
            while (check == false)
            {
                Console.WriteLine("Please choose opponent \n1)Human \n2)Computer");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        return 1;
                    case 2:
                        return 2;
                    default:
                        Console.WriteLine("Sorry, that is not valid. Please enter 1 or 2");
                        break;
                }
            }
            return 2;

        }

        public int ChooseSeriesLength()
        {
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("How long would you like the game to be?");
                Console.WriteLine("1) Best of 3?");
                Console.WriteLine("2) Best of 7?");
                Console.WriteLine("3) Best of 11?");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        return 3;
                    case 2:
                        return 7;
                    case 3:
                        return 11;
                    default:
                        Console.WriteLine("Sorry, that is not valid. Please enter 1, 2, or 3");
                        break;

                }
            }
            return 1; 
        }

        public int ShowGestureOptions(Player player)
        {
            Console.WriteLine("Please select a gesture");
            for(int i = 0; i < player.gestures.Count; i++)
            {
                Console.WriteLine($"{i+1}) {player.gestures[i].name}");
            }
            bool valid = false;
            while (valid == false)
            {
                int userChoice = Convert.ToInt32(Console.ReadLine());
                
                switch (userChoice)
                {
                    case 1:
                        return 1;
                    case 2:
                        return 2;
                    case 3:
                        return 3;
                    case 4:
                        return 4;
                    case 5:
                        return 5;
                    default:
                        Console.WriteLine("Sorry, that input is not valid. Please enter a number 1-5");
                        break;
                }
            }
            return 0;
        }

        public void DeclareRoundWinner(int i, Player player1, Player player2)
        {
            if (i < 2)
            {
                Console.WriteLine($"{player1.name} {player1.gestureList[2].name} beats {player2.name} {player1.gestureList[i].name}. Player 1 wins!");
                player1.score++;
            }
            else if (i > 2)
            {
                Console.WriteLine($"{player2.name} {player1.gestureList[i].name} beats {player1.name} {player1.gestureList[2].name}. Player 2 wins!");
                player2.score++;
            }
            else
            {
                Console.WriteLine($"{player1.gestureList[3]} vs. {player1.gestureList[i]} It's a tie!");
            }
        }

        public void ShowScore(Player player1, Player player2)
        {
            if (player1.score > player2.score)
            {
                Console.WriteLine($"{player1.name} is beating {player2.name} {player1.score}-{player2.score}");
            }
            else if (player1.score < player2.score)
            {
                Console.WriteLine($"{player2.name} is beating {player1.name} {player2.score}-{player1.score}");
            }
            else if (player1.score == player2.score)
            {
                Console.WriteLine($"The game is tied {player1.score}-{player2.score}");
            }
            
        }
    }
}
