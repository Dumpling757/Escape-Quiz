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
        public Wahrheitswerttabelle(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            this.FrameQuestion.Navigate(new SC_Datenspeicher_View(this.FrameQuestion));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
