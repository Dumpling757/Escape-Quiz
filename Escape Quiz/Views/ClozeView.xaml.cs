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
    /// Interaktionslogik für ClozeView.xaml
    /// </summary>
    public partial class ClozeView : UserControl
    {
        private Frame frame;
        public ClozeView(Frame frame)
        {
            InitializeComponent();

            this.frame = frame;
        }


        /*
         * this.frame.Navigate(new Quiz2View(this.frame));
         * Wie generalisiert man den Konstruktor Call?
         */
    }
}
