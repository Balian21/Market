using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiaTestFactorial
{
    internal class Program
    {
        private static void Main()
        {
            Recursia rec = new Recursia();
            int p = Convert.ToInt32(Console.ReadLine());
            rec.Start(p);
            Console.ReadLine();
        }
    }

    internal class Recursia
    {
        private int result;

        public void Start(int input)
        {
            result = input;
            Factorial(input);
            Console.WriteLine(result);
        }

        public void Factorial(int i)
        {
            Console.WriteLine(i);
            if (i == 1)
            {
                return;
            }
            i--;
            result *= i;
            Factorial(i);
        }
    }
}