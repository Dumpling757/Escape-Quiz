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
            bool correct = false;
            Answer.Background = Score.Wrong;
            Answer.IsEnabled = false;

            string answerstring = Answer.Text;
            answerstring = answerstring.ToLower();

            string regstring = "s+";
            Regex r = new Regex(regstring);
            r.Replace(answerstring, "");

            if (answerstring == "hypertextmarkuplanguage" || Answer.Text == "Hypertext Markup Language" || answerstring.ToLower() == "hypertext markup language")
            {
                Answer.Background = Score.Right;
                Answer.Foreground = new SolidColorBrush(Colors.White);
                correct = true;
            }
            else Answer.Foreground = new SolidColorBrush(Colors.White); 

            if(clickI > 0)
            {
                if(correct)
                Score.OneUp();

                if (Score.GetScore() < 7)
                    this.frame.Navigate(new MC_Peripheriegeraete(this.frame));
                else
                    this.frame.Navigate(new EndView(this.frame));
            }
            clickI++;
            ButtonNext.Content = "Nächste Frage";
        }
    }
}
