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
    }
}
