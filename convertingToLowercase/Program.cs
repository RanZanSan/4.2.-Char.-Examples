using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertingToLowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(char.ToLower('B')); // 'b'
            Console.WriteLine(char.ToLower('b')); // 'b'
            Console.WriteLine(char.ToLower('5')); // '5'
            Console.ReadKey();
        }
    }
}