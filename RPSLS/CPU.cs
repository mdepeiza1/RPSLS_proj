using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class CPU : Player
    {
        public CPU()
        {

        }

        public void DisplayGestures()
        {

        }
        public override Gesture ThrowGesture(int i)
        {
            return this.weaponry.ElementAt(i - 1);
        }
        public override Tuple<int, int> CompareGestures(int p1score, int p2score, Gesture g1, Gesture g2)
        {
            if (g1.name == "Rock" && g2.name == "Scissors")
            {
                p1score++;
                Console.WriteLine("Player One won!");
            }
            else if (g1.name == "Paper" && g2.name == "Rock")
            {
                p1score++;
                Console.WriteLine("Player One won!");
            }
            else if (g1.name == "Scissors" && g2.name == "Paper")
            {
                p1score++;
                Console.WriteLine("Player One won!");
            }
            else if (g1.name == "Rock" && g2.name == "Lizard")
            {
                p1score++;
                Console.WriteLine("Player One won!");
            }
            else if (g1.name == "Paper" && g2.name == "Spock")
            {
                p1score++;
                Console.WriteLine("Player One won!");
            }
            else if (g1.name == "Scissors" && g2.name == "Lizard")
            {
                p1score++;
                Console.WriteLine("Player One won!");
            }
            else if (g1.name == "Lizard" && g2.name == "Spock")
            {
                p1score++;
                Console.WriteLine("Player One won!");
            }
            else if (g1.name == "Spock" && g2.name == "Scissors")
            {
                p1score++;
                Console.WriteLine("Player One won!");
            }
            else if (g1.name == "Lizard" && g2.name == "Paper")
            {
                p1score++;
                Console.WriteLine("Player One won!");
            }
            else if (g1.name == "Spock" && g2.name == "Rock")
            {
                p1score++;
                Console.WriteLine("Player One won!");
            }
            else if (g2.name == "Rock" && g1.name == "Scissors")
            {
                p2score++;
                Console.WriteLine("Player Two won!");
            }
            else if (g2.name == "Paper" && g1.name == "Rock")
            {
                p2score++;
                Console.WriteLine("Player Two won!");
            }
            else if (g2.name == "Scissors" && g1.name == "Paper")
            {
                p2score++;
                Console.WriteLine("Player Two won!");
            }
            else if (g2.name == "Rock" && g1.name == "Lizard")
            {
                p2score++;
                Console.WriteLine("Player Two won!");
            }
            else if (g2.name == "Paper" && g1.name == "Spock")
            {
                p2score++;
                Console.WriteLine("Player Two won!");
            }
            else if (g2.name == "Scissors" && g1.name == "Lizard")
            {
                p2score++;
                Console.WriteLine("Player Two won!");
            }
            else if (g2.name == "Lizard" && g1.name == "Spock")
            {
                p2score++;
                Console.WriteLine("Player Two won!");
            }
            else if (g2.name == "Spock" && g1.name == "Scissors")
            {
                p2score++;
                Console.WriteLine("Player Two won!");
            }
            else if (g2.name == "Lizard" && g1.name == "Paper")
            {
                p2score++;
                Console.WriteLine("Player Two won!");
            }
            else if (g2.name == "Spock" && g1.name == "Rock")
            {
                p2score++;
                Console.WriteLine("Player Two won!");
            }
            else //The gestures should be the same.
            {
                Console.WriteLine("There was a tie!");
            }
            return Tuple.Create(p1score, p2score);
        }

    }
}
