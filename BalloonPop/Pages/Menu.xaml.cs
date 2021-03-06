﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace BalloonPop.Pages
{
    public sealed partial class Menu : Page
    {
        public Menu()
        {
            this.InitializeComponent();
            this.JoystickOn = true;
        }

        private bool JoystickOn { get; set; }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Animation), this.JoystickOn);
        }

        private void ShowScores(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ResultPage));
        }

        private void authorsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Authors));
        }

        private void TurnJoystickOn(object sender, RoutedEventArgs e)
        {
            this.JoystickOn = !this.JoystickOn;

            if (this.JoystickOn)
            {
                this.TurnJoystickOnButton.Content = "Joystick: On";
            }
            else
            {
                this.TurnJoystickOnButton.Content = "Joystick: Off";
            }
        }
    }
}
