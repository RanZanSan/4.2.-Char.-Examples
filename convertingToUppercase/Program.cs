using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertingToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(char.ToUpper('b')); // 'B'
            Console.WriteLine(char.ToUpper('B')); // 'B'
            Console.WriteLine(char.ToUpper('5')); // '5'
            Console.ReadKey();
        }
    }
}