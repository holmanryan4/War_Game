using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Game
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        int playerOneScore;
        int playerTwoScore;
        int playerOneRoll;
        int playerTwoRoll;

        //Constructor - Sets the scores to 0 when a new game is created
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }
        //Don't change anything above this ^^^^^^^^^^^^

        //Member Methods - All your methods go below here!
        public void StartMenu()
        {
            Console.WriteLine("Hello and Welcome to the game Roll! Hit enter to start");
            Console.ReadLine();  
        }
        Random random = new Random();
        public int RollDice()
        { 
            int result;
            result = random.Next(1, 7);
            return result;
        }

        public void CompareRoll()
        {

            while (playerOneScore < 3 && playerTwoScore < 3)
            {
                playerOneRoll = RollDice();
                playerTwoRoll = RollDice();

                if (playerOneRoll == playerTwoRoll)
                {
                    Console.WriteLine(" player One Rolled: " + playerOneRoll);
                    Console.WriteLine(" player Two Rolled: " + playerTwoRoll);
                    Console.WriteLine("Tie! Roll Again");
                    Console.WriteLine("Player One score is " + playerOneScore);
                    Console.WriteLine("Player Two score is " + playerTwoScore);
                    Console.ReadLine();

                }

                if (playerOneRoll > playerTwoRoll)
                {
                    Console.WriteLine(" player One Rolled: " + playerOneRoll);
                    Console.WriteLine(" player Two Rolled: " + playerTwoRoll);
                    Console.WriteLine("Player One: YOU WIN!!!");
                    playerOneScore++;
                    Console.WriteLine("Player One score is " + playerOneScore);
                    Console.WriteLine("Player Two score is " + playerTwoScore);
                    Console.WriteLine();

                }
                else if (playerOneRoll < playerTwoRoll)
                {
                    Console.WriteLine(" player One Rolled: " + playerOneRoll);
                    Console.WriteLine(" player Two Rolled: " + playerTwoRoll);
                    Console.WriteLine("PlayerTwo: YOU WIN!!");
                    playerTwoScore++;
                    Console.WriteLine("Player One score is " + playerOneScore);
                    Console.WriteLine("Player Two score is " + playerTwoScore);

                }
                Console.ReadLine();
                continue;
            }

        }

        public void DisplayGameWinner()
        {
            if (playerOneScore == 3)
            {
                Console.WriteLine("Player One you are the game winner!!!! Thanks for playing!");


            }
            if (playerTwoScore == 3)
            {
                Console.WriteLine("Player Two you are the game winner!!!! Thanks for playing!");
            }
            Console.ReadLine();
        }

        //This is the main method that is called in the Program when you press Start
        //Call your other methods inside this method
        public void RunGame()
        {
            StartMenu();
            RollDice();
            CompareRoll();
            DisplayGameWinner();

        }
    }
}
