﻿using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;

namespace _4_hodina_vidostop
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int skore;
        int cislo1;
        int cislo2;
        int cislo3;
        DispatcherTimer casovac;
        Random rnd;
        string[] obrazky;


        public MainWindow()
        {
            InitializeComponent();

            skore = 0;
            casovac = new DispatcherTimer();
            casovac.Interval = new TimeSpan(0, 0, 1);
            casovac.Tick += Casovac_Tick;
            rnd = new Random();
            obrazky = Directory.GetFiles(Directory.GetCurrentDirectory() + "/obrazky/");
        }

        private void Casovac_Tick(object sender, EventArgs e)
        {
            cislo1 = rnd.Next(5);
            img1.Source = new BitmapImage(new Uri(obrazky[cislo1]));
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
