using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        List<string> Choices = new List<string> { "rock", "paper", "scissors", "spock", "lizard" };
        public void StartGame()
        {
            DisplayWelcomeMessage();
            ShowRules();
            ChoosePlayers();
            RunGame();
        }

        private void RunGame()
        {
            while(playerOne.GetScore() < 2 && playerTwo.GetScore() < 2)
            {
                playerOne.MakeChoice();
                playerTwo.MakeChoice();
                EvaluateChoice();

            }
            DisplayWinner();
            ChooseRestart();
        }

        private void ChooseRestart()
        {
            Console.WriteLine("Would you like to play another game (Y|N)");
            string userInput = Console.ReadLine().ToLower();
            if(userInput == "y")
            {
                StartGame();
            }
            else if (userInput == "n")
            {
                Console.WriteLine("Have a nice day");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invaild Input: Please enter a correct choice");
                ChooseRestart();
            }
        }

        private void DisplayWinner()
        {
            if(playerOne.GetScore() > playerTwo.GetScore())
            {
                Console.WriteLine("Congrats Player One you Won");
            }
            else if(playerOne.GetScore() < playerTwo.GetScore())
            {
                Console.WriteLine("Congrats Player Two, you Won");
            }

            else if(playerOne.GetScore() == playerTwo.GetScore())
            {
                Console.WriteLine("You are both losers, you tied");
            }
        }

        private void EvaluateChoice()
        {
            int numberOfPotentialChoices = Choices.Count;
            int winQuotient = (numberOfPotentialChoices + Choices.IndexOf(playerOne.GetChoice()) - Choices.IndexOf(playerTwo.GetChoice())) % numberOfPotentialChoices;
            if (winQuotient == 0)
            {
                Console.WriteLine("It was a tie");
            }
            else if (winQuotient % 2 == 0)
            {
                Console.WriteLine("Player Two wins");
                playerTwo.AddPointToScore();
            }
            else if (winQuotient % 2 != 0)
            {
                Console.WriteLine("Player One wins");
                playerOne.AddPointToScore();
            }
        }

        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the super awesome game");
            Console.WriteLine("This is Rock Paper Scissors Lizard Spock");

        }
        public void ShowRules()
        {
            Console.WriteLine("Here is where I would type all the rules to the game");
            Console.WriteLine("The only thing I would do in this method is show the rules");
        }
        public void ChoosePlayers()
        {
            Console.WriteLine("Please choose 1 or 2 players");
            string numberOfPlayers = Console.ReadLine();
            if (numberOfPlayers == "1")
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (numberOfPlayers == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Invalid selection: Please enter either 1 or 2");
                ChoosePlayers();
            }

        }
    }
}
