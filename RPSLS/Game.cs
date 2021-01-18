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
        int choiceOfMultiPlayerOrSinglePlayer;

        //constructor
        public Game()
        {
            //if user picks single player create human and cpu
            //else make two humans
            // should this be where I call my ChoosePlayer?
            DisplayRules();
            choiceOfMultiPlayerOrSinglePlayer = ChooseSingleOrMultiPlayer();
            CreatePlayers(choiceOfMultiPlayerOrSinglePlayer);
        }

        // Display Rules
        // Choose Single or Multiplayer
        // RunGame Logic
        // compare gestures for a round, 
        // score the round
        // and keep track of a winner once a certain score is hit

        //public void CompareGestures()
        //{ 
        //  logic: displayGestures
        //  logic: ThrowGestures
        //  logic: Compare the Gestures
        //}
        public void RunGame()
        {
            if(choiceOfMultiPlayerOrSinglePlayer == 1)
            {
                OnePlayerBattle();
            }
            else
            {
                TwoPlayerBattle();
            }

            DisplayWinner(choiceOfMultiPlayerOrSinglePlayer);
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

        public void OnePlayerBattle() // Could this be a single method for 
            // two player and one player?
        {
            int playerOneChoice;
            int playerTwoChoice;
            Gesture g1;
            Gesture g2;
            Random randomNumberFrom1To5 = new Random();

            while (p1score < 2 && p2score < 2)
            {
                Console.WriteLine("Player One, choose your gesture! ");
                playerOne.DisplayGestures();

                while (true) // helper method?
                {
                    if (Int32.TryParse(Console.ReadLine(), out int choice))
                    {
                        if(choice > 5 || choice < 1)
                        {
                            Console.WriteLine("Please enter an integer from 1 to 5.");
                        }
                        else
                        {
                            playerOneChoice = choice;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer.");
                    }
                }
                g1 = playerOne.ThrowGesture(playerOneChoice);

                Console.WriteLine("Now the CPU is choosing a gesture!");
                playerTwoChoice = randomNumberFrom1To5.Next(1,6);
                g2 = playerTwo.ThrowGesture(playerTwoChoice);

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
                Console.WriteLine("Player One, choose your gesture! ");
                playerOne.DisplayGestures();
                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out int choice))
                    {
                        if (choice > 5 || choice < 1)
                        {
                            Console.WriteLine("Please enter an integer from 1 to 5.");
                        }
                        else
                        {
                            playerOneChoice = choice;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer.");
                    }
                }
                g1 = playerOne.ThrowGesture(playerOneChoice);

                Console.WriteLine("Player Two, choose your gesture! ");
                playerTwo.DisplayGestures();
                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out int choice))
                    {
                        if (choice > 5 || choice < 1)
                        {
                            Console.WriteLine("Please enter an integer from 1 to 5.");
                        }
                        else
                        {
                            playerTwoChoice = choice;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer.");
                    }
                }
                g2 = playerTwo.ThrowGesture(playerTwoChoice);

                BattleLogic(g1, g2);
            }
        }

        public void BattleLogic(Gesture g1, Gesture g2)
        {
                var scores = playerTwo.CompareGestures(p1score, p2score, g1, g2); // might need to put the logic of this method back into BattleLogic()
                p1score = scores.Item1;
                p2score = scores.Item2;
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
