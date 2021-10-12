using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowercaseDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(char.IsLower('b')); // True
            Console.WriteLine(char.IsLower('B')); // False
            Console.WriteLine(char.IsLower('и')); // True
            Console.WriteLine(char.IsLower('И')); // False
            Console.ReadKey();
        }
    }
}