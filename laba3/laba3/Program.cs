using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {



            int a;
            int b;
            Console.WriteLine("menu");
            Console.WriteLine("nazhmite 1 i vvedite a");
            Console.WriteLine("nazhmite 2 i vvedite b");
            Console.WriteLine("vvedite simvol: \n3: +\n4: -\n5: *\n6: /");

            ConsoleKeyInfo key = Console.ReadKey();
            char c = key.KeyChar;


            if (c == 1)

            if (c == 2)

            {
                Console.Write("vvod b: ");
                b = int.Parse(Console.ReadLine());
            }
            

        }
    }
}
