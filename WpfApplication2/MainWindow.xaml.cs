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

        public void Operatory();
        {
        float zmienna1 = 10f;
        int zmienna2 = 20;

       var wynik = zmienna1 + zmienna2;
        var wynik2 = zmienna1 - zmienna2;
        var wynik3 = zmienna1 * zmienna2;
        var wynik4 = zmienna1 / zmienna2;

        var wynik5 = zmienna1++;
        var wynik6 = zmienna1--;


        }




        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            short liczbaPolubien = 10;
            const float PI = 3.14f;
            float r = 10f;

            var wynik = PI * r * r;
            
            var naszPierwszyVar = liczbaPolubien; 
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            





        }
    }
}
