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
        public void StartGame()
        {
            DisplayWelcomeMessage();
            ShowRules();
            ChoosePlayers();
            RunGame();
        }

        private void RunGame()
        {
            throw new NotImplementedException();
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
