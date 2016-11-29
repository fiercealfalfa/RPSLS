using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        protected int score = 0;
        protected string choice;
        public int GetScore()
        {
            return score;
        }
        public void AddPointToScore()
        {
            score++;
        }
        public string GetChoice()
        {
            return choice;
        }
        public virtual void MakeChoice()
        {
            Console.WriteLine("This is the base function, something has gone wrong if you see this");
            throw new Exception();
        }
    }
}
