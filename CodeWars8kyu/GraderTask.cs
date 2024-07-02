using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class GraderTask
    {
        public static char Grader(double score)
        {
            if (score >= 0.9 && score < 1.01) return 'A';
            if (score >= 0.8 && score < 0.9) return 'B';
            if (score >= 0.7 && score < 0.8) return 'C';
            if (score >= 0.6 && score < 0.7) return 'D';

            return 'F';
        }
    }
}
//https://www.codewars.com/kata/53d16bd82578b1fb5b00128c/train/csharp