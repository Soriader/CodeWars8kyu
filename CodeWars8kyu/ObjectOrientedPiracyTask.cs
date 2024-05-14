using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ObjectOrientedPiracyTask
    {
        public int Draft;
        public int Crew;

        public ObjectOrientedPiracyTask(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }

        public bool IsWorthIt()
        {
            if (Draft - (Crew * 1.5) > 20)
            {
                return true;
            }

            return false;
        }
    }
}
//https://www.codewars.com/kata/54fe05c4762e2e3047000add/train/csharp