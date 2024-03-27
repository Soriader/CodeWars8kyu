using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class TerminalGameCombatFunctionTask
    {
        public static float Combat(float health, float damage)
        {
            var characterHealth = health - damage;

            if(characterHealth < 0) 
            {
                return 0;
            }
            return characterHealth;
        }
    }
}
//https://www.codewars.com/kata/586c1cf4b98de0399300001d/train/csharp