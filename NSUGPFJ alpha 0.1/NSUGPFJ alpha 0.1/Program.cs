using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSUGPFJ_alpha_0._1
{
    class Program
    {
        static void Main(string[] args)
        {



            string pokrm1;
            string pokrm2;
            string pokrm3;
            string pokrm4;
            string pokrm5;

            string ingredience1;
            string ingredience2;
            string ingredience3;
            string ingredience4;
            string ingredience5;
            string ingredience6;
            string ingredience7;
            string ingredience8;
            string ingredience9;
            string ingredience0;


            Console.WriteLine("Zadej pokrmy (oddělené čárkou)");
            string vstup;
            vstup = Console.ReadLine();
            char splitter = ',';
            var splitted = vstup.Split(splitter);
            pokrm1 = (splitted[0]);
            pokrm2 = (splitted[1]);
            pokrm3 = (splitted[2]);
            pokrm4 = (splitted[3]);
            pokrm5 = (splitted[4]);

            Console.WriteLine("Zadej ingredience (v 7. pádě, oddělené čárkou)");
            string vstupi;
            vstupi = Console.ReadLine();
            char splitteri = ',';
            var splittedi = vstupi.Split(splitteri);
            ingredience1 = (splittedi[0]);
            ingredience2 = (splittedi[1]);
            ingredience3 = (splittedi[2]);
            ingredience4 = (splittedi[3]);
            ingredience5 = (splittedi[4]);
            ingredience6 = (splittedi[5]);
            ingredience7 = (splittedi[6]);
            ingredience8 = (splittedi[7]);
            ingredience9 = (splittedi[8]);
            ingredience0 = (splittedi[9]);



            Console.WriteLine(pokrm1, pokrm2, pokrm3, pokrm4, pokrm5, ingredience1, ingredience2, ingredience3, ingredience4, ingredience5, ingredience6, ingredience7, ingredience8, ingredience8, ingredience9, ingredience0);

            Console.ReadKey();

















        }
    }
}
