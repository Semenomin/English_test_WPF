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
using System.Windows.Shapes;

namespace EnglishTests
{
    /// <summary>
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Window
    {
        List<ScrollViewer> scrollViewers = new List<ScrollViewer>();
        List<Grid> Chapter2List = new List<Grid>();
        public Test1()
        {
            InitializeComponent();

            Chapter2List.Add(Theory2G);
            Chapter2List.Add(Voc2);
          


            scrollViewers.Add(Theory1);
            scrollViewers.Add(Theory2);
            scrollViewers.Add(Theory3);
            scrollViewers.Add(Theory4);
            scrollViewers.Add(Theory5);
            scrollViewers.Add(Theory6);
            Chap1.MouseUp += Ch1_MU;
            Chap2.MouseUp += Ch2_MU;
            Chap3.MouseUp += Ch3_MU;
            Chap4.MouseUp += Ch4_MU;
            Chap5.MouseUp += Ch5_MU;
            Chap6.MouseUp += Ch6_MU;
        }

        #region Chapter2

        private void Btn0_ch2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter2List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter2List[0].Visibility = Visibility.Visible;
        }
        
        private void Btn1_ch2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter2List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter2List[1].Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch2.IsEnabled = true;
            foreach (Grid a in Chapter2List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter2List[1].Visibility = Visibility.Visible;
        }
        #endregion





















        private void Ch1_MU(object sender, MouseButtonEventArgs e)
        {
            foreach (ScrollViewer a in scrollViewers)
            {
                a.Visibility = Visibility.Hidden;
            }
            Theory1.Visibility = Visibility.Visible;
        }
        private void Ch2_MU(object sender, MouseButtonEventArgs e)
        {
            foreach (ScrollViewer a in scrollViewers)
            {
                a.Visibility = Visibility.Hidden;
            }
            
        }
        private void Ch3_MU(object sender, MouseButtonEventArgs e)
        {
            foreach (ScrollViewer a in scrollViewers)
            {
                a.Visibility = Visibility.Hidden;
            }
            Theory3.Visibility = Visibility.Visible;
        }
        private void Ch4_MU(object sender, MouseButtonEventArgs e)
        {
            foreach (ScrollViewer a in scrollViewers)
            {
                a.Visibility = Visibility.Hidden;
            }
            Theory4.Visibility = Visibility.Visible;
        }
        private void Ch5_MU(object sender, MouseButtonEventArgs e)
        {
            foreach (ScrollViewer a in scrollViewers)
            {
                a.Visibility = Visibility.Hidden;
            }
            Theory5.Visibility = Visibility.Visible;
        }
        private void Ch6_MU(object sender, MouseButtonEventArgs e)
        {
            foreach (ScrollViewer a in scrollViewers)
            {
                a.Visibility = Visibility.Hidden;
            }
            Theory6.Visibility = Visibility.Visible;
        }

       
    }
}
