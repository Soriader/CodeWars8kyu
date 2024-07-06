using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars8kyu
{
    public class FinishGuessTheNumberGameTask
    {
        private int number;
        private int lives;

        public FinishGuessTheNumberGameTask(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n)
        {
            if (lives < 1) throw new Exception("You gone!");

            if (n == number) return true;

            --lives;
            return false;
        }
    }
}
