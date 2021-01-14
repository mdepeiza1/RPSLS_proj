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
            // should this be where I call my ChoosePlayer?
            
        }
        public void RunGame()
        {
            DisplayRules();
            CreatePlayers(ChooseSingleOrMultiPlayer());
            Battle();
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
        public void Battle()
        {
            int playerOneChoice;
            int playerTwoChoice;

            Console.WriteLine("Player One, choose your gesture! " +
                "1 is Rock. " +
                "2 is Paper. " +
                "3 is Scissors. " +
                "4 is Lizard. " +
                "5 is Spock. ");
            playerOneChoice = Int32.Parse(Console.ReadLine());

            if(playerOneChoice == 1)
            {
                playerOne.weaponry.ElementAt(playerOneChoice - 1);
            }
            else if(playerOneChoice == 2)
            {

            }

            Console.WriteLine("Player Two, choose your gesture! " +
                "1 is Rock. " +
                "2 is Paper. " +
                "3 is Scissors. " +
                "4 is Lizard. " +
                "5 is Spock. ");
            playerTwoChoice = Int32.Parse(Console.ReadLine());
        }
    }
}
