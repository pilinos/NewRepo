using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = -10000;; i++)
                Console.Write("{0} ", i);
            Console.ReadKey();
        }
    }
}
