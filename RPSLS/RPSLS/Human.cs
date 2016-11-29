using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        public override void MakeChoice()
        {
            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock");
            string userChoice = Console.ReadLine().ToLower();
            switch (userChoice)
            {
                case "rock":
                case "paper":
                case "scissors":
                case "lizard":
                case "spock":
                    choice = userChoice;
                    break;
                default:
                    Console.WriteLine("Invaild choice, please enter a vaild choice");
                    MakeChoice();
                    break;
             
            }
        }
    }
}
