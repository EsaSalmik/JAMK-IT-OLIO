using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            tehtava1();
        }

        static void tehtava1()
        {
            Console.WriteLine("Anna luku 1-3 > ");
            string syote = Console.ReadLine();
            int numero = int.Parse(syote);
            if (numero == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            }
            else if (numero == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            }
            else
            {
                Console.WriteLine("Anna luku 1-3 > ");
                tehtava1();
            }
            Console.ReadLine();
        }
    }

}
