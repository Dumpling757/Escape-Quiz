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

namespace Escape_Quiz.Views
{
    /// <summary>
    /// Interaktionslogik für MC_KommazahlenView.xaml
    /// </summary>
    public partial class MC_KommazahlenView : UserControl
    {
        private Frame frame;
        private int clickI;
        public MC_KommazahlenView(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
            // multipleChoice.SetOptionsTrue()
        }


        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            
            /*
            List<bool> answers = new List<bool>();
            answers.Add((bool)cbBoolean.IsChecked);
            answers.Add((bool)cbDouble.IsChecked);
            answers.Add((bool)cbFloat.IsChecked);
            answers.Add((bool)cbInteger.IsChecked);

            multipleChoice.CheckAnswer(answers);
            */
                
            
            cbDouble.Foreground = Score.Wrong;
            cbDouble.IsEnabled = false;
            cbFloat.Foreground = Score.Wrong;
            cbDouble.IsEnabled = false;

            cbInteger.Foreground = Score.Wrong;
            cbInteger.IsEnabled = false;
            cbBoolean.Foreground = Score.Wrong;
            cbBoolean.IsEnabled = false;



            if (clickI > 0)
            {
                if ((bool)cbDouble.IsChecked && (bool)cbFloat.IsChecked)
                {
                    cbDouble.Foreground = Score.Right;
                    cbInteger.Foreground = Score.Right;
                    Score.OneUp();
                }

                if (Score.GetScore() < 7)
                    this.frame.Navigate(new Freitext2View(this.frame));
                else
                    this.frame.Navigate(new EndView(this.frame));
                

            }
            clickI++;
            ButtonNext.Content = "Nächste Frage";

            

        }
    }
}
