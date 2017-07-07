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

namespace WpfApplication1
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        byte malaLiczba;
        int liczbaCalkowita = 10;
        long liczbaCalkowitadluga = 1000000;
        short liczbaCalkowitakrotka = 255;
        float liczbaZmiennoprzecinkowa = 1.2f;
        double liczbaZmiennoprzecinkowa2 = 1.2;
        bool prawdaFalsz = false;
        string tekst = "to jest prawidłowy tekst";
            ulong liczbaCałkowitaDlugaDodatnia = ulong.MaxValue;
           
        public MainWindow() 
        {
            InitializeComponent();

           }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            short liczbaPolubien = 10;
            var naszPierwszyVar = liczbaPolubien; 
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            





        }
    }
}
