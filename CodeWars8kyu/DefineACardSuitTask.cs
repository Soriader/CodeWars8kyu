using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class DefineACardSuitTask
    {
        public static string DefineSuit(string card)
        {
            var result = card.ToCharArray();
        
            for (int i = 0; i < result.Length; i++)
            {
                switch (result[i])
                {
                    case '♣':
                        {
                            return "clubs";
                        }
                    case '♦':
                        {
                            return "diamonds";
                        }
                    case '♥':
                        {
                            return "hearts"; 
                        }
                    case '♠':
                        {
                            return "spades";
                        }
                }
            }

            return null;
        
        }
    }
}
//https://www.codewars.com/kata/5a360620f28b82a711000047/train/csharp