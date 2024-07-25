using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class WilsonPrimesTask
	{
		public static bool AmIWilson(int p)
		{
			if (!IsPrime(p))
				return false;

			BigInteger factorial = Factorial(p - 1);
			BigInteger check = (factorial + 1) % (p * p);

			return check == 0;
		}

		public static BigInteger Factorial(int n)
		{
			BigInteger result = 1;
			for (int i = 2; i <= n; i++)
			{
				result *= i;
			}
			return result;
		}

		public static bool IsPrime(int n)
		{
			if (n <= 1) return false;
			if (n == 2) return true;

			for (int i = 2; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0) return false;
			}
			return true;
		}

	}
}
//https://www.codewars.com/kata/55dc4520094bbaf50e0000cb/train/csharp