using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int y1;
            int x2;
            int y2;


            Console.WriteLine("Zadej souřadnice");
            string vstup;
            vstup = Console.ReadLine();
            char splitter = ',';
            var splitted = vstup.Split(splitter);
            x1 = int.Parse(splitted[0]);
            y1 = int.Parse(splitted[1]);
            x2 = int.Parse(splitted[2]);
            y2 = int.Parse(splitted[3]);

            Console.WriteLine(x1);
            Console.WriteLine(y1);
            Console.WriteLine(x2);
            Console.WriteLine(y2);

            Console.ReadKey();
            Char obaDole = '_';
            Char pravaNahoreLevaDole = '/';
            Char levaNahorePravaDole = '\\';

            int[,] canvas = new int[80, 25];















            Console.ReadKey();








        }
        static void DrawLine(int[,] canvas, int x1, int y1, int x2, int y2)



            static bool DrawLine(int[,] canvas, int x1, int y1, int x2, int y2)
        {


        }
                
                
                
                
                
                
                
                }
    }
}