using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
  public class Vehicle
  {
    //constants and variables
    private const int maxTyres = 4;
    private int countTyres = 0;
    //properties
    public string Brand { get; set; }
    public string Model { get; set; }
    //taulukon koko on kiinteä
    public Tyre[] Tyres { get; }
    //tyypitetty lista on dynaaminen
    public List<Tyre> Renkaat { get; }
    //constructors
    public Vehicle()
    {
      Tyres = new Tyre[maxTyres];
      Renkaat = new List<IT.Tyre>();
    }
    //methods
    public void AddTyre(Tyre tyre)
    {
      if (countTyres < maxTyres)
      {
        Tyres[countTyres] = tyre;
        countTyres++;
        Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", tyre.ToString(), this.Brand);
      }
      else
      {
        Console.WriteLine("Ei sovi enää uusia renkaita, sorry");
      }
    }
    //metodi jolla lisätään listaan uusi rengas
    public void AddTyreToList(Tyre tyre)
    {
      Renkaat.Add(tyre);
    }
    public override string ToString()
    {
      string retval = "Ajoneuvo valmistaja: " + Brand + " malli: " + Model + "\nrenkaat:";
      foreach (Tyre tyre in Tyres)
      {
        if (tyre != null)
        {
          retval += "\n" + tyre.ToString();
        }
      }
      //ja listataan listan alkiot myös
      foreach (Tyre tyre in Renkaat)
      {
        retval += "\n" + tyre.ToString();
      }
      return retval;
    }
  }
  public class Tyre
  {
    public string Branch { get; set; }
    public string Size { get; set; }
    public override string ToString()
    {
      //return "Valmistaja: " + Branch + " koko: " + Size;
      return String.Format("Valmistaja on {0} koko on  {1}", Branch, Size);
    }
  }
}
