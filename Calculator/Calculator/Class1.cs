using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        public void CalcMethod()
        {
            Console.WriteLine("Enter first digit:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation (+,-,*,/):");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter second digit:");
            int m = Convert.ToInt32(Console.ReadLine());

            if (operation == "+")
            {
                Console.WriteLine("Result:");
                Console.WriteLine(n + m);
            }
            else if (operation == "-")
            {
                Console.WriteLine("Result:");
                Console.WriteLine(n - m);
            }
            else if (operation == "*")
            {
                Console.WriteLine("Result:");
                Console.WriteLine(n * m);
            }
            else if (operation == "/")
            {
                Console.WriteLine("Result:");
                Console.WriteLine(n / m);
            }
            else
            {
                Console.WriteLine("Result:");
                Console.WriteLine("Something get wrong");
            }
        }
    }
}
