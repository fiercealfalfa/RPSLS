using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        Random random = new Random();
        public override void MakeChoice()
        {
            List<string> Choices = new List<string> { "rock", "paper", "scissors", "spock", "lizard" };
          choice = Choices[random.Next(0,5)];

        }
    }
}
