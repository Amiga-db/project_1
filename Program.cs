using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace _1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            if (a > b)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("a більше");
            }
        }
    }
}