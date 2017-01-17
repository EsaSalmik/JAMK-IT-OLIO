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
      Tehtava1();
    }

    static void Tehtava1()
    {
      //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
      Console.WriteLine("Anna 1,2 tai 3 ja tulostan sen tekstinä");
      string retval = Console.ReadLine();
      int luku = int.Parse(retval);
      if (luku == 1)
      {
        retval = "yksi";
      }
      else if (luku == 2)
      {
        retval = "kaksi";
      }
      else if (luku == 3)
      {
        retval = "kolme";
      }
      else
      {
        retval = "joku muu luku";
      }
      //tulostus käyttäjälle
      Console.WriteLine(retval);
    }
  }
}
