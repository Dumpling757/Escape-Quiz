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
    /// Interaktionslogik für Freitext1View.xaml
    /// </summary>
    public partial class Freitext1View : UserControl
    {
        private Frame frame;
        private int clickI;
        public Freitext1View(Frame frame)
        {
            this.frame = frame;
            InitializeComponent();
        }
        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            Answer.Background = Score.Wrong;

            string answerstring = Answer.Text;
            answerstring.ToLower();

            string regstring = @"\s+";
            Regex r = new Regex(regstring);
            r.Replace(answerstring, "");

            if (answerstring == "hypertextmarkuplanguage")
            {
                Score.OneUp();
                Answer.Background = Score.Right;
            }

            if(clickI > 0)
            {
                this.frame.Navigate(new SymbolView(this.frame));
            }
            clickI++;
        }
    }
}
