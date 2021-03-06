﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace risu_win
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Costruttore
        public MainPage()
        {
            InitializeComponent();
        }

        private void title_bottom_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	NavigationService.Navigate(new Uri("/Ricerca_pivot.xaml", UriKind.Relative));
        }

        private void Cerca_bmenu_Click(object sender, System.EventArgs e)
        {
			NavigationService.Navigate(new Uri("/Ricerca_pivot.xaml", UriKind.Relative));
        }

        private void Indici_bmenu_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Indici_pivot.xaml", UriKind.Relative));
        }

        private void Liste_bmenu_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Liste_pivot.xaml", UriKind.Relative));
        }

        private void Preferiti_bmenu_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Preferiti_page.xaml", UriKind.Relative));
        }

        private void Changelog_bmenu_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Changelog_page.xaml", UriKind.Relative));
        }
    }
}