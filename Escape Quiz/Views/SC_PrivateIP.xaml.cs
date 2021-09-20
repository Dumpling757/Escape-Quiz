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

namespace Escape_Quiz.Views
{
    /// <summary>
    /// Interaktionslogik für SC_PrivateIP.xaml
    /// </summary>
    public partial class SC_PrivateIP : UserControl
    {
        private Frame frame;

        // Button Click Counter, dass beim ersten Click nur die richtigkeit der Fragen angeteigt wird.
        private int clickI;
        public SC_PrivateIP(Frame frame)
        {
            this.frame = frame;
            InitializeComponent();
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            privIP.Foreground = Score.Wrong;
            privIP.IsEnabled = false;
            localhost.Foreground = Score.Wrong;
            localhost.IsEnabled = false;
            pubIP.Foreground = Score.Wrong;
            pubIP.IsEnabled = false;
            APIPA.Foreground = Score.Wrong;
            APIPA.IsEnabled = false;

            if ((bool)privIP.IsChecked)
            {
                //MessageBox.Show("Richtig!");
                privIP.Foreground = Score.Right;

            }
            if (clickI > 0)
            {
                if((bool)privIP.IsChecked)
                    Score.OneUp();

                MessageBox.Show(Convert.ToString(Score.GetScore()));


                if (Score.GetScore() < 7)
                    this.frame.Navigate(new LT_PraefixView(this.frame));
                else
                    this.frame.Navigate(new EndView(this.frame));
                

            }
            clickI++;
            ButtonNext.Content = "Nächste Frage";
        }
    }
}
