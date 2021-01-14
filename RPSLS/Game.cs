using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables
        Player playerOne;
        Player playerTwo;

        //constructor
        public Game()
        {
            //if user picks single player create human and cpu
            //else make two humans
            DisplayRules();
            CreatePlayers(ChooseSingleOrMultiPlayer());
        }

        //member methods
        public void DisplayRules() //change to fleshed out method
        {
            Console.WriteLine("This is a game of Rock, Paper, Scissors, Lizard, Spock. " +
                "Rock beats Scissors. " +
                "Paper beats Rock. " +
                "Scissors beats Paper. " +
                "Rock beats Lizard. " +
                "Paper beats Spock. " +
                "Scissors beats Lizard. " +
                "Lizard beats Spock. " +
                "Spock beats Scissors. " +
                "Lizard beats Paper. " +
                "Spock beats Rock. " +
                "Press enter to continue.");
            Console.ReadLine();
        }
        public int ChooseSingleOrMultiPlayer()
        {
            int result1;
            Console.WriteLine("Please enter 1 for a single " +
                "player game, and 2 for a multiplayer game.");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out int result2))
                {
                    if ((result2 == 1) || (result2 == 2))
                    {
                        result1 = result2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your input was not 1 or 2. " +
                        "Please enter either 1 or 2.");
                    }
                }
                else
                {
                    Console.WriteLine("Your input was not an integer. " +
                        "Please enter an integer.");
                }
            }
            return result1;
        }
        public void CreatePlayers(int choiceOfMultiOrSinglePlayer)
        {
            playerOne = new Human();
            if (choiceOfMultiOrSinglePlayer == 1)
            {
                playerTwo = new CPU();
            }
            if(choiceOfMultiOrSinglePlayer == 2)
            {
                playerTwo = new Human();
            }
        }
    }
}
