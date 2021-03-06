﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TOYOTAcars;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Toyota_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class location : Page
    {
        public location()
        {
            this.InitializeComponent();
            web_location.Navigate(new Uri("https://www.google.com/maps/dir/''/118,+Karachi+75500/@24.8369315,66.9994109,12z/data=!3m1!4b1!4m8!4m7!1m0!1m5!1m1!1s0x3eb33c3e3184dd3b:0x151c9bc8c86ee350!2m2!1d67.0694513!2d24.8369478"));
        }

        private void btn_selectvechile_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(cars_item_page));
        }

        private void btn_showroom_location_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(location));
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void feedback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(feedback));
        }
    }
}
