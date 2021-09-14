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
using System.Text.RegularExpressions;

namespace Escape_Quiz.Views
{
    /// <summary>
    /// Interaktionslogik für LT_PraefixView.xaml
    /// </summary>
    public partial class LT_PraefixView : UserControl
    {
        private Frame frame;

        private int clickI;
        public LT_PraefixView(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            // Whitespace removal
            string regstring = @"\s+";
            Regex r = new Regex(regstring);

            r.Replace(LT_TB1.Text, "");
            r.Replace(LT_TB2.Text, "");

            if(LT_TB1.Text == "16" && LT_TB2.Text == "255.255.255.255")
            {

            }

            if(LT_TB1.Text == "16")
            {
                LT_TB1.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                LT_TB1.Foreground = new SolidColorBrush(Colors.Red);
            }

            if(LT_TB2.Text == "255.255.255.255")
            {
                LT_TB2.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                LT_TB2.Foreground = new SolidColorBrush(Colors.Red);
            }

            if (clickI > 0)
            {
                this.frame.Navigate(new MC_KommazahlenView(this.frame));
            }
            clickI++;
            ButtonNext.Content = "Náchste Frage"; 

        }
    }
}
