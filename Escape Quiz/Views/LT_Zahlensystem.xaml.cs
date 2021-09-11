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
    /// Interaktionslogik für LT_Zahlensystem.xaml
    /// </summary>
    public partial class LT_Zahlensystem : UserControl
    {
        private Frame frame;
        public LT_Zahlensystem(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

       

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new SymbolView(this.frame));
        }
    }
}
