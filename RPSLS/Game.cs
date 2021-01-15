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
        int p1score = 0;
        int p2score = 0;

        //constructor
        public Game()
        {
            //if user picks single player create human and cpu
            //else make two humans
            // should this be where I call my ChoosePlayer?
            
        }
        public void RunGame()
        {
            int choiceOfMultiOrSinglePlayer;
            DisplayRules();
            choiceOfMultiOrSinglePlayer = ChooseSingleOrMultiPlayer();
            CreatePlayers(choiceOfMultiOrSinglePlayer);
            if(choiceOfMultiOrSinglePlayer == 1)
            {
                OnePlayerBattle();
            }
            
            if(choiceOfMultiOrSinglePlayer == 2)
            {
                TwoPlayerBattle();
            }
            DisplayWinner(choiceOfMultiOrSinglePlayer);
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

        public void OnePlayerBattle()
        {
            int playerOneChoice;
            int playerTwoChoice;
            Gesture g1;
            Gesture g2;

            while (p1score < 2 && p2score < 2)
            {
                Console.WriteLine("Player One, choose your gesture! " +
                    "1 is Rock. " +                      //may have to change this to playerOne.weaponry.ElementAt(0).name
                    "2 is Paper. " +
                    "3 is Scissors. " +
                    "4 is Lizard. " +
                    "5 is Spock. ");
                playerOneChoice = Int32.Parse(Console.ReadLine());
                g1 = playerOne.weaponry.ElementAt(playerOneChoice - 1);

                Console.WriteLine("Player Two, choose your gesture! " +
                    "1 is Rock. " +
                    "2 is Paper. " +
                    "3 is Scissors. " +
                    "4 is Lizard. " +
                    "5 is Spock. ");
                playerTwoChoice = Int32.Parse(Console.ReadLine());
                g2 = playerTwo.weaponry.ElementAt(playerTwoChoice - 1);

                BattleLogic(g1, g2);
            }
        }

        public void TwoPlayerBattle()
        {
            int playerOneChoice;
            int playerTwoChoice;
            Gesture g1;
            Gesture g2;

            while (p1score < 2 && p2score < 2)
            {
                Console.WriteLine("Player One, choose your gesture! " +
                    "1 is Rock. " +
                    "2 is Paper. " +
                    "3 is Scissors. " +
                    "4 is Lizard. " +
                    "5 is Spock. ");
                playerOneChoice = Int32.Parse(Console.ReadLine());
                g1 = playerOne.weaponry.ElementAt(playerOneChoice - 1);

                Console.WriteLine("Player Two, choose your gesture! " +
                    "1 is Rock. " +
                    "2 is Paper. " +
                    "3 is Scissors. " +
                    "4 is Lizard. " +
                    "5 is Spock. ");
                playerTwoChoice = Int32.Parse(Console.ReadLine());
                g2 = playerTwo.weaponry.ElementAt(playerTwoChoice - 1);

                BattleLogic(g1, g2);
            }
        }

        public void BattleLogic(Gesture g1, Gesture g2)
        {
            if(g1.name == "Rock" && g2.name == "Scissors")
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
        }

        public void DisplayWinner(int choiceOfMultiOrSingle)
        {
            if(choiceOfMultiOrSingle == 1)
            {
                if (p1score == 2)
                {
                    Console.WriteLine("Player One won the game!");
                }
                if (p2score == 2)
                {
                    Console.WriteLine("The CPU won the game!");
                }
            }
            else
            {
                if (p1score == 2)
                {
                    Console.WriteLine("Player One won the game!");
                }
                if (p2score == 2)
                {
                    Console.WriteLine("Player Two won the game!");
                }
            } 
        }
    }
}
