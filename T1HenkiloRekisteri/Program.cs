using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T1HenkiloRekisteri
{
  class Program
  {
    static void Main(string[] args)
    {
      TestaaHenkiloRekisteri();
    }

    static void TestaaHenkiloRekisteri()
    {
      //luodaan muutama testi henkilö
      Henkilot poppoo = new Henkilot();
      Henkilo hlo = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "311270-123A" };
      Henkilo hlo1 = new Henkilo { Etunimi = "Kirsi", Sukunimi = "Kernell", Hetu = "121270-234B" };
      Henkilo hlo2 = new Henkilo { Etunimi = "Mat", Sukunimi = "Mickelson", Hetu = "011280-456C" };
      //lisätään henkilöt poppooseen
      poppoo.LisaaHenkilo(hlo);
      poppoo.LisaaHenkilo(hlo1);
      poppoo.LisaaHenkilo(hlo2);

      //tulostetaan poppoo näytölle foreach
      foreach (Henkilo h in poppoo.Henkilolista)
      {
        Console.WriteLine("Henkilö {0}", h.ToString());
      }
      //löytyykö Jussia poppoosta
      Henkilo testi = new Henkilo { Etunimi = "Jussi", Sukunimi = "Pussinen", Hetu = "010199-001A" };
      poppoo.PoistaHenkilo(testi);
      //tulostetaan poppoo näytölle for loopilla
      Console.WriteLine("Löytyy {0} henkilöä:", poppoo.Henkilolista.Count);
      for (int i = 0; i < poppoo.Henkilolista.Count; i++)
      {
        Console.WriteLine("Henkilö {0}", poppoo.HaeHenkilo(i).ToString());
      }

      //TODO kysy käyttäjältä  hetu ja haetaan sitä vastaava  henkilö näytölle

    }
  }
}
