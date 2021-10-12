using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());
            if (char.IsDigit(c))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}