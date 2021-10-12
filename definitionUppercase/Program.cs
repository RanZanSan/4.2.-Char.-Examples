using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definitionUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(char.IsUpper('b')); // False
            Console.WriteLine(char.IsUpper('B')); // True
            Console.WriteLine(char.IsUpper('и')); // False
            Console.WriteLine(char.IsUpper('И')); // True
            Console.ReadKey();
        }
    }
}