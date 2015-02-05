using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathLibrary;

namespace DLLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 2;

            int c = MathMathods.Add(a, b);
            int d = MathMathods.Multiply(b, a);

            Console.WriteLine(c + " " + d);

        }
    }
}
