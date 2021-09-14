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

            if (FirstTB.Text == "1")
            {
                FirstTB.Background;
            }

            if(ThirdTB.Text == "1")
            {
                ThirdTB.Background;
            }

            if(FourthTB.Text == "1")
            {
                FourthTB.Background;
            }
            if(FifthTB.Text == "1")
            {
                FifthTB.Background;
            }

            if(clickI > 0)
            {
                this.FrameQuestion.Navigate(new SC_Datenspeicher_View(this.FrameQuestion));

            }
            clickI++;
            ButtonNext.Content = "Nächste Frage";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
