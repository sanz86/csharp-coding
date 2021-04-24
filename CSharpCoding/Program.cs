using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            NQueensProblemTest();

            Console.ReadKey();
            Console.WriteLine("Press any key to exit");
        }

        private static void NQueensProblemTest()
        {
            NQueensProblem nQueensProblem = new NQueensProblem();

            nQueensProblem.Solve(5);

            nQueensProblem.Solve(8);

            nQueensProblem.Solve(20);
        }
    }
}
