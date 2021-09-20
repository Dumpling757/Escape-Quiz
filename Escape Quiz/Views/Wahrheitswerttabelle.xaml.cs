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
    /// Interaktionslogik für Wahrheitswerttabelle.xaml
    /// </summary>
    public partial class Wahrheitswerttabelle : UserControl
    {
        private Frame frame;
        private int rightI;

        private int clickI;
        public Wahrheitswerttabelle(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {

            Brush right = new SolidColorBrush(Colors.Green);
            Brush wrong = new SolidColorBrush(Colors.Red);

            FirstTB.Background = wrong;
            FirstTB.IsEnabled = false;
            ThirdTB.Background = wrong;
            ThirdTB.IsEnabled = false;
            FourthTB.Background = wrong;
            FourthTB.IsEnabled = false;
            FifthTB.Background = wrong;
            FifthTB.IsEnabled = false;

                if (FirstTB.Text == "0")
                {
                    FirstTB.Background = right;
                    rightI++;
                }


                if (ThirdTB.Text == "1")
                {
                    ThirdTB.Background = right;
                    rightI++;
                }

                if (FourthTB.Text == "1")
                {
                    FourthTB.Background = right;
                    rightI++;
                }
                if (FifthTB.Text == "1")
                {
                    FifthTB.Background = right;
                    rightI++;
                }
            }
            

            if (clickI > 0)
            {
                if (rightI == 4)
                {
                    Score.OneUp();
                }


                if (Score.GetScore() < 7)
                    this.FrameQuestion.Navigate(new SC_Datenspeicher_View(this.FrameQuestion));
                else
                    this.FrameQuestion.Navigate(new EndView(this.frame));
                

            }
            clickI++;
            ButtonNext.Content = "Nächste Frage";
        }


    }
}
