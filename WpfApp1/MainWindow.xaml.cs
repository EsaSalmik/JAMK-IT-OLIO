using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private const float kurssi = 0.8997F;
    public MainWindow()
    {
      InitializeComponent();
    }

    private void txtEuro_TextChanged(object sender, TextChangedEventArgs e)
    {
      //lasketaan dollarit
      txtDollari.Text = (float.Parse(txtEuro.Text) / kurssi).ToString("0.00");
    }
  }
}
