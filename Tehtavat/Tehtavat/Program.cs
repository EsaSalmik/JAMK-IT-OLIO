/* Anton Telegey kotitehtavat
* tehty 17.1.17
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio1
{
    class Kayttaja
    {
        public string Nimi { get; set; }
    }
    //luodaan Henkilo niminen luokka johon kuuluu nimi ja ika kentät.
    class Henkilo
    {
        //get - lukea, set - asettaa.
        public string Nimi { get; set; }
        public int Ika { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            valikko();
        }
        static void valikko()
        {
            Console.Clear();
            int valinta = 111;
            while (valinta != 0)
            {
                Console.WriteLine("1. SayHello() \n");
                Console.WriteLine("2. AksAge() \n");
                Console.WriteLine("3. kayttajat() \n");
                Console.WriteLine("4. arvonta() \n");
                Console.WriteLine("5. tehtava1() \n"); 
                Console.WriteLine("0. Lopeta \n");
                Console.WriteLine("Valitse ohjelma 1-4: ");
                string syote = Console.ReadLine();
                valinta = int.Parse(syote);

                if (valinta == 1)
                {
                    SayHello();
                }
                else if (valinta == 2)
                {
                    AksAge();
                }
                else if (valinta == 3)
                {
                    kayttajat();
                }
                else if (valinta == 4)
                {
                    arvonta();
                }
                else if (valinta == 5)
                {
                    tehtava1();
                }
                else
                {
                    Console.WriteLine("Valitse ohjelma 1-4.");
                }
                Console.ReadLine();
            }
        }
        static void SayHello()
        {
            Henkilo immeinen = new Henkilo();
            immeinen.Nimi = "Ville Petteri";
            immeinen.Ika = 25;
            //naytetaan olion tiedot loppukayttajalle
            Console.WriteLine("Hello " + immeinen.Nimi + ".");
            Console.WriteLine("Olet " + immeinen.Ika + " vuotias.");
            //talla saa konsolin jaamaan nakyviin
            Console.ReadLine();
            valikko();
        }
        static void AksAge()
        {
            Console.WriteLine("Syota syntymavuosi: ");
            string syote = Console.ReadLine();
            int vuosi = int.Parse(syote);
            Console.WriteLine("Syota syntymakuukausi: ");
            string syote2 = Console.ReadLine();
            int kk = int.Parse(syote2);
            Console.WriteLine("Syota syntymapaiva: ");
            string syote3 = Console.ReadLine();
            //Muutetaan syote int muotoon string muodosta.
            int pv = int.Parse(syote3);
            int kuluvavuosi = DateTime.Today.Year;
            int kuluvakuukausi = DateTime.Today.Month;
            int kuluvapaiva = DateTime.Today.Day;
            int ika;
            ika = kuluvavuosi - vuosi;
            if (kk == kuluvakuukausi)
            {
                if (pv >= kuluvapaiva)
                {
                    ika--;
                }
            }
            Console.WriteLine("Olet " + ika + " vuotias.");
            Console.ReadLine();
            valikko();
        }
        static void kayttajat()
        {


            string[] array = new string[5];
            Console.WriteLine("Anna käyttäjien etunimet:");
            for (int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Annoit nimet: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nNimet aakkosjärjetyksessä: ");
            Array.Sort(array);
            foreach (string k in array)
            {
                Console.Write(k + " ");
            }
            Console.ReadLine();
            valikko();
        }
        static void arvonta()
        {
            Console.Write("Anna arvottavien rivien määrä > ");
            string syote = Console.ReadLine();
            int rivit = int.Parse(syote);

            Random rand = new Random();

            for (int i = 1; i < rivit + 2; i++)
            {
                int[] lotto = new int[7];
                Console.Write("Rivi " + i + ": ");

                for (int n = 0; n < 7;)
                {
                    int check = rand.Next(1, 41);
                    while (!(lotto.Contains(check)))
                    {
                        lotto[n] = check;
                        n++;
                        //Console.Write(check);
                        //if (n < 7) { Console.Write(","); }
                    }
                    //if (n > 6) { Console.WriteLine(""); }
                }
                //for (int b = 0; b < lotto.Length; b++) Console.Write(lotto[b]);

                Array.Sort(lotto);
                for (int b = 0; b < lotto.Length; b++)
                {
                    Console.Write(lotto[b]);
                    if (b < 6) { Console.Write(", "); } else { Console.Write("\n"); }
                }
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava1()
        {
            int numero;
            Console.WriteLine("Anna luku 1-3 > ");
            string syote = Console.ReadLine();
            numero = int.Parse(syote);
            if (numero == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            } else if (numero == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            } else  if (numero == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            } else {
                Console.WriteLine("Anna luku 1-3 > ");
            }
            Console.ReadLine();
        }
        static void tehtava2 ()
        {
            int numero;
            Console.WriteLine("Anna pistemäärä 0-12 > ");
            string syote = Console.ReadLine();
            numero = int.Parse(syote);
            if (numero == 0 || numero == 1)
            {
                Console.WriteLine("Koulunumero on 0");
            }
            else if (numero == 2 || numero == 3)
            {
                Console.WriteLine("Koulunumero on 1");
            }
            else if (numero == 4 || numero == 5)
            {
                Console.WriteLine("Koulunumero on 2");
            }
            else if (numero == 6 || numero == 7)
            {
                Console.WriteLine("Koulunumero on 3");
            }
            else if (numero == 8 || numero == 9)
            {
                Console.WriteLine("Koulunumero on 4");
            }
            else if (numero == 10 || numero == 11 || numero == 12)
            {
                Console.WriteLine("Koulunumero on 5");
            }
            else
            {
                Console.WriteLine("Anna pistemäärä 0-12 > ");
            }
            Console.ReadLine();
        }
        static void tehtava3 ()
        {
            int[] array = new int[3];
            Console.WriteLine("Syota 3 numeroa:");
            for (int i = 0; i < 3; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int size = array.Length;
            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }
            average = sum / size;
            Console.WriteLine("Summa: " + sum);
            Console.WriteLine("Keskiarvo: " + average);
            Console.ReadLine();
            valikko();
        }
        static void tehtava4 ()
        {

        }
    }
}