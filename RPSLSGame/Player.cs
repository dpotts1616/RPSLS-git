using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    abstract class Player
    {
        //member variables
        public List<Gesture> gestures;
        public List<Gesture> gestureList;
        public string name;
        public int score;

        //constructor
        public Player()
        {
            gestures = new List<Gesture>();
            gestures.Add(new Rock());
            gestures.Add(new Paper());
            gestures.Add(new Scissors());
            gestures.Add(new Lizard());
            gestures.Add(new Spock());
        }

        //methods
        public void CreateGestureList(int userChoice)
        {
            gestureList = new List<Gesture>();
            switch (userChoice)
            {
                case 1:
                    gestureList = RockList();
                    break;
                case 2:
                    gestureList = PaperList();
                    break;
                case 3:
                    gestureList = ScissorsList();
                    break;
                case 4:
                    gestureList = LizardList();
                    break;
                case 5:
                    gestureList = SpockList();
                    break;
            }
        }

        public List<Gesture> RockList()
        {
            gestureList.Add(new Lizard());
            gestureList.Add(new Scissors());
            gestureList.Add(new Rock());
            gestureList.Add(new Spock());
            gestureList.Add(new Paper());
            return gestureList;
        }

        public List<Gesture> PaperList()
        {
            gestureList.Add(new Rock());
            gestureList.Add(new Spock());
            gestureList.Add(new Paper());
            gestureList.Add(new Lizard());
            gestureList.Add(new Scissors());
            return gestureList;
        }

        public List<Gesture> ScissorsList()
        {
            gestureList.Add(new Paper());
            gestureList.Add(new Lizard());
            gestureList.Add(new Scissors());
            gestureList.Add(new Rock());
            gestureList.Add(new Spock());
            return gestureList;
        }

        public List<Gesture> LizardList()
        {
            gestureList.Add(new Spock());
            gestureList.Add(new Paper());
            gestureList.Add(new Lizard());
            gestureList.Add(new Scissors());
            gestureList.Add(new Rock());
            return gestureList;
        }

        public List<Gesture> SpockList()
        {
            gestureList.Add(new Scissors());
            gestureList.Add(new Rock());
            gestureList.Add(new Spock());
            gestureList.Add(new Paper());
            gestureList.Add(new Lizard());
            return gestureList;
        }

        public void ResetBoard()
        {
            gestureList.Clear();
        }

        //public virtual string GetPlayer2Choice()
        //{

        //}

    }
}
