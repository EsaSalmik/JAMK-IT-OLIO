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

namespace WPFHello
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    //laskuri
    private int cnt;
    public MainWindow()
    {
      InitializeComponent();
      cnt = 0;
      textBlock1.Text = cnt.ToString();
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
      textBlock.Text = "Hello " + textBox.Text;
      MessageBox.Show("Terve " + textBox.Text, "Esa's Messut");
      cnt++;
      textBlock1.Text = cnt.ToString();
    }

    private void button_Copy_Click(object sender, RoutedEventArgs e)
    {
      //kutsutaan näkyviin About -niminen ikkuna
      About aboutWin = new WPFHello.About();
      //huom ikkuna voi olla joko modaalinen tai tavallinen
      //aboutWin.ShowDialog(); //modaalinen
      aboutWin.Show();
    }
  }
}
