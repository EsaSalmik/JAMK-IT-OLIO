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
using System.Windows.Shapes;

namespace WPFHello
{

  /// <summary>
  /// Interaction logic for Second.xaml
  /// </summary>
  public partial class Second : Window
  {
    //ominaisuus
    private string username;
    public string UserName
    {
      get { return username; }
      set { username = value; }
    }
    public Second()
    {
      InitializeComponent();
      tbMessage.Text = "username is now : " + username;
    }

    private void btnSay_Click(object sender, RoutedEventArgs e)
    {
      tbMessage.Text = "Hello: " + username;
    }
  }
}
