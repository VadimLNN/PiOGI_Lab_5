using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Write B");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Select operation + - * /");
            string op = Console.ReadLine();

            if (op == "/")
                Console.WriteLine(A / B);

            Console.ReadKey();
        }
    }
}
