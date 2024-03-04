using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RockPaperScissorsTask
    {
        public static string Rps(string p1, string p2)
        {
            switch (p1)
            {
                case "rock":
                    {
                        if (p2 == "scissors")
                        {
                            return "Player 1 won!";
                        }
                        if (p2 == "paper")
                        {
                            return "Player 2 won!";
                        }
                        else
                        {
                            return "Draw!";
                        }
                    }
                case "scissors":
                    {
                        if (p2 == "paper")
                        {
                            return "Player 1 won!";
                        }
                        if (p2 == "rock")
                        {
                            return "Player 2 won!";
                        }
                        else
                        {
                            return "Draw!";
                        }
                    }
                case "paper":
                    {
                        if (p2 == "rock")
                        {
                            return "Player 1 won!";
                        }
                        if (p2 == "scissors")
                        {
                            return "Player 2 won!";
                        }
                        else
                        {
                            return "Draw!";
                        }
                    }
            }

            return "";
        }
        //https://www.codewars.com/kata/5672a98bdbdd995fad00000f/train/csharp
    }
}
