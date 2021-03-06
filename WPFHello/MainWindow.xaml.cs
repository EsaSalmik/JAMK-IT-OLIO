﻿using System;
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
      txbCounter.Text = cnt.ToString();
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
      txbHello.Text = "Hello " + txtName.Text;
      cnt++;
      txbCounter.Text = cnt.ToString();
      //ilmoitus tilariville
      txbMessages.Text = "Painoit buttosta btnSayHello";
    }

    private void button_Copy_Click(object sender, RoutedEventArgs e)
    {
      //käyttäjän nimi
      string nahmen = txtName.Text;
      //kutsutaan näkyviin About -niminen ikkuna
      About aboutWin = new WPFHello.About();
      //huom ikkuna voi olla joko modaalinen tai tavallinen
      //aboutWin.ShowDialog(); //modaalinen
      aboutWin.Show();
      //ja sitten uudestaan
      About aw2 = new WPFHello.About("Jack Russell");
      aw2.ShowDialog();
    }

    private void btnSecond_Click(object sender, RoutedEventArgs e)
    {
      //kutsutaan uutta ikkunaa
      Second swin = new Second();
      swin.UserName = "Jack Russell";
      swin.ShowDialog();
    }
  }
}
