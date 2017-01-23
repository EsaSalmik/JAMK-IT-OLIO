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
            tehtava7();
            //valikko();
        }
        static void valikko()
        {
            Console.Clear();
            int valinta = 111;
            while (valinta != 0)
            {
                Console.WriteLine("1. SayHello() ");
                Console.WriteLine("2. AksAge() ");
                Console.WriteLine("3. kayttajat() ");
                Console.WriteLine("4. arvonta() ");
                Console.WriteLine("5. tehtava1() ");
                Console.WriteLine("6. tehtava2() ");
                Console.WriteLine("7. tehtava3() ");
                Console.WriteLine("8. tehtava4() ");
                Console.WriteLine("9. tehtava5() ");
                Console.WriteLine("0. Lopeta ");
                Console.WriteLine("Valitse ohjelma: ");
                string syote = Console.ReadLine();
                valinta = int.Parse(syote);

                if (valinta == 0)
                {
                    
                }
                else if (valinta == 1)
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
                else if (valinta == 6)
                {
                    tehtava2();
                }
                else if (valinta == 7)
                {
                    tehtava3();
                }
                else if (valinta == 8)
                {
                    tehtava4();
                }
                else if (valinta == 9)
                {
                    tehtava5();
                }
                else
                {
                    valikko();
                }
                
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
            valikko();
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
            valikko();
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
            Console.WriteLine("Minka ikainen olet?:");
            string syote = Console.ReadLine();
            int ika = int.Parse(syote);
            if (ika < 18)
            {
                Console.WriteLine("Olet alaikainen.");
            } else if (ika > 17 && ika < 66) {
                Console.WriteLine("Olet aikuinen.");
            } else if (ika > 65)
            {
                Console.WriteLine("Olet seniori.");
            } else
            {
                tehtava4();
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava5()
        {
            Console.Write("Anna sekunnit > ");
            string syote = Console.ReadLine();
            int sekunnit = int.Parse(syote);

            int tunnit = sekunnit / 3600;
            int minuutit = sekunnit / 60 / 60;
            int sek = minuutit / 60;

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tunnit + " tunti " + minuutit + " minuutti " + sek + " sekuntti");
            Console.ReadLine();
            valikko();
        }
        static void tehtava6()
        {
            Console.Write("Anna ajokilometrit > ");
            string syote = Console.ReadLine();
            int km = int.Parse(syote);
            Double bensa = km * 0.0702;
            Double menot = bensa * 1.595;

            Console.WriteLine("Bensa kulutus: " + bensa);
            Console.WriteLine("Menot: " + menot + " euroa.");
            Console.ReadLine();
            valikko();
        }
        static void tehtava7()
        {
            Console.Write("Anna vuosiluku > ");
            string syote = Console.ReadLine();
            int vuosi = int.Parse(syote);

            int karkausvuosi = vuosi % 4;

            if (karkausvuosi == 0) {
                if (vuosi % 400 == 0)
                {
                    Console.Write("Vuosiluku: " + vuosi + " on karkausvuosi");
                } else if (vuosi % 100 == 0)
                {
                    Console.Write("Vuosiluku: " + vuosi + " ei ole karkausvuosi");
                }

            } else
            {
                Console.Write("Vuosiluku: " + vuosi + " ei ole karkausvuosi");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava8() {
                int[] array = new int[3];
                Console.WriteLine("Syota 3 numeroa: ");
                for (int i = 0; i < 3; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(array);
                Array.Reverse(array);
                Console.WriteLine("Suurin numero on: " + array[0];
                Console.ReadLine();
                valikko();
        }
        static void tehtava9() {
                int summa = 0;
                do {
                    Console.WriteLine("Syota numero: ");
                    string syote = Console.ReadLine();
                    int numero = int.Parse(syote);
                    summa = summa + numero;
                } while (numero != 0)
                Console.WriteLine("Lukujen summa on " + summa);
                Console.ReadLine();
                valikko();
        }
        static void tehtava10() {
            int[] taulukko = new int[9] {1,2,33,44,55,68,77,96,100}
            for (int b = 0; b < taulukko.Length; b++) {
                    Console.Write(taulukko[b]);
                    if (taulukko[b] % 2 == 0 ) { Console.Write("HEP"); }
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava11 () {
            Console.WriteLine("Syota numero: ");
            string syote = Console.ReadLine();
            int numero = int.Parse(syote);
            for (int i = 0; i =< numero; i++) {
                for (int a = 0; a = i; i++) {
                    Console.Writeline("*");
                }
            }
            Console.ReadLine();
            valikko();
        }

        static void tehtava12() {
            lukuja = 5;
            int[] array = new int[lukuja];
            for (int i = 0; i < lukuja; i++)
            {
                Console.WriteLine("Anna luku > ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(array);
            foreach (string k in array)
            {
                Console.Write("Luvut ovat: " + k + ", ");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava13() {
            lukuja = 5;
            summa = 0;
            int size = array.Length;

            int[] array = new int[lukuja];
            for (int i = 0; i < lukuja; i++)
            {
                Console.WriteLine("Anna pisteet > ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);

            for (int i = 0; i < size; i++)
            {
                summa += array[i];
            }
            summa = summa - array[0] - array[4];
            Console.WriteLine("Kokonaispisteet ovat " + summa);
            Console.ReadLine();
            valikko();
        }
        static void tehtava14() {
            int opiskelijoita = 8;
            int arvosana0 = 0;
            int arvosana1 = 0;
            int arvosana2 = 0;
            int arvosana3 = 0;
            int arvosana4 = 0;
            int arvosana5 = 0;

            for (int i = 0; i < opiskelijoita; i++)
            {
                Console.WriteLine("Anna arvosana > ");
                string syote = Console.ReadLine();
                int numero = int.Parse(syote);
                if (numero == 0) {
                    arvosana0 = arvosana0 + 1;
                } else if (numero == 1) {
                    arvosana1 = arvosana1 + 1;
                } else if (numero == 2) {
                    arvosana2 = arvosana2 + 1;
                } else if (numero == 3) {
                    arvosana3 = arvosana3 + 1;
                } else if (numero == 4) {
                    arvosana4 = arvosana4 + 1;
                } else if (numero == 5) {
                    arvosana5 = arvosana5 + 1;
                }
            }
            Console.WriteLine("Arvosanat:");
            Console.WriteLine("0:");
            for (int i = 0; i < arvosana0; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("1:");
            for (int i = 0; i < arvosana1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("2:");
            for (int i = 0; i < arvosana2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("3:");
            for (int i = 0; i < arvosana3; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("4:");
            for (int i = 0; i < arvosana4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("5:");
            for (int i = 0; i < arvosana5; i++)
            {
                Console.Write("*");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava15() {
            Console.WriteLine("Anna luku > ");
            string syote = Console.ReadLine();
            int numero = int.Parse(syote);
            int puu = numero - 2;
            jalka = 2;

            for (int i = 0; i < puu; i++)
                {
                    int vali = puu - i;
                    for (int a = 0; a <= vali; a++)
                    {
                        Console.Write(" ");
                    }
                    for (int tahti = 0; tahti <= i * 2; star++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < jalka; i++)
                {
                    for (int a = 0; a <= puu; a++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                Console.ReadLine();
                valikko();
        }
        static void tehtava16() {
            Random rand = new Random();
            int random = rand.Next(1, 101);
            Console.WriteLine("Arvaa luku > ");
            string syote = Console.ReadLine();
            int arvottu = int.Parse(syote);
            arvauksia = 0;
            while(random != arvottu) {
                arvauksia++;
                if (arvottu > random) {
                    Console.WriteLine("Numero on pienempi ");
                } else if (arvottu < random) {
                    Console.WriteLine("Numero on suurempi ");
                } 
            } 
            Console.WriteLine("Hienoa, arvasit luvun " + arvauksia + " kerralla.");
            Console.ReadLine();
            valikko();
        }
        static void tehtava17() {
            int[] taulukko1 = new int[5] {10,20,30,40,50}
            int[] taulukko2 = new int[5] {5,15,25,35,45}
            int[] yhdistettytaulukko = new int[10];
            yhdistettytaulukko = taulukko1 + taulukko2;
            Array.Sort(yhdistettytaulukko);
            int size = yhdistettytaulukko.Length;
            Console.WriteLine("Luvut yhdistetyssä taulukossa : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(yhdistettytaulukko[i] + ",");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava18() {
            Console.Write("Kirjoita joku lause : ");
            string lause = Console.ReadLine();
            int pituus = line.Length;

            for (int i = 0; i < pituus / 2; i++)
            {
                if (lause[i] != lause[pituus - i - 1])
                {
                    Console.WriteLine("Lause ei ole palidromi.");
                } else {
                    Console.WriteLine("Lause on palidromi.");
                }
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava19() {
            string sana = "opiskelija";
            int pituus = line.length;
            string arvattu;
                
            for (int i = 0; i < pituus; i++) {
                Console.WriteLine("Arvaa seuraava kirjain");
                char kirjain = Console.ReadLine();
                if (kirjain == sana[i]) {
                    arvattu = arvattu + sana[i];
                    ConsoleWrite(arvattu);
                }
            }
            Console.WriteLine("Arvaa uksesi oli: " + arvattu);
            Console.WriteLine("Oikea sana on: " + sana);
            Console.ReadLine();
            valikko();
        }
    }
}