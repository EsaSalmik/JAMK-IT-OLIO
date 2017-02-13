using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; //for ObservableCollection
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using JAMK.ICT;

namespace WPFDataBindaus
{
  /// <summary>
  /// Interaction logic for DataBindDemo.xaml
  /// </summary>
  public partial class DataBindDemo : Window
  {
    //koska useampi metodi=tapahtumankäsittelijä tulee käyttämään näitä muuttujia -->
    //määritellään luokan tasolle luokan jäsenmuuttujiksi
    JAMK.ICT.HockeyLeague liiga;
    ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
    int counter = 0;
    public DataBindDemo()
    {
      InitializeComponent();
      IniMyStuff();
    }
    private void IniMyStuff()
    {
      //tänne kootusti omien kontrollien alustukset
      List<string> muuvit = new List<string>();
      muuvit.Add("Halloween");
      muuvit.Add("Jaws");
      muuvit.Add("Star Wars");
      muuvit.Add("Pahat pojat");
      cmbMovies.ItemsSource = muuvit;
      //haetaan SMLiiga-joukkueet
      liiga = new JAMK.ICT.HockeyLeague();
      joukkueet = liiga.GetTeams();
      cmbTeams.ItemsSource = joukkueet;
    }

    private void btnBind_Click(object sender, RoutedEventArgs e)
    {
      //määritellään Stackpanelin DataContext
      //Demo1: Datacontekstini on olio
      //HockeyTeam tiimi = new JAMK.ICT.HockeyTeam("KeuPa", "Keuruu");
      //spRight.DataContext = tiimi;
      //demo2: kytketään olio-kokoelman 1. olioon
      spRight.DataContext = joukkueet[counter];
    }
  }
}
