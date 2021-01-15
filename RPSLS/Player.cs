using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public List<Gesture> weaponry;
        public Player()
        {
            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissors scissors = new Scissors();
            Lizard lizard = new Lizard();
            Spock spock = new Spock();
            weaponry = new List<Gesture>();
            weaponry.Add(rock);
            weaponry.Add(paper);
            weaponry.Add(scissors);
            weaponry.Add(lizard);
            weaponry.Add(spock);
        }

        public abstract Tuple<int, int> CompareGestures(int p1score, int p2score, Gesture g1, Gesture g2);
        public abstract Gesture ThrowGesture(int i);

        public abstract void DisplayGestures();
    }
}
