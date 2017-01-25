using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
  /// <summary>
  /// This class contains person properties
  /// </summary>
  class Henkilo
  {
    public string Etunimi { get; set; }
    public string Sukunimi { get; set; }
    public string Hetu { get; set; }
    public override string ToString()
    {
      return Etunimi + " " + Sukunimi + " " + Hetu;
    }
  }
  ///This class holsd person information in a collection
  ///
  class Henkilot
  {
    //properties
    private List<Henkilo> henkilot;
    public List<Henkilo> Henkilolista
    {
      get { return henkilot; }
    }
    public Henkilot()
    {
      henkilot = new List<Henkilo>();
    }
    public void LisaaHenkilo(Henkilo hlo)
    {
      henkilot.Add(hlo);
    }
    public void PoistaHenkilo(Henkilo hlo)
    {
      if (henkilot.Contains(hlo))
      { 
      henkilot.Remove(hlo);
      }
    }
    public Henkilo HaeHenkilo(int index)
    {
      if (index < henkilot.Count)
      {
        //return henkilot.ElementAt(index);
        return henkilot[index];
      }
      else
      {
        return null;
      }
    }
    public Henkilo HaeHenkiloHetulla(string hetu)
    {
      foreach (Henkilo hlo in henkilot)
      {
        if (hlo.Hetu == hetu)
        {
          return hlo;
        }
      }
      return null;
    }
  }
}
