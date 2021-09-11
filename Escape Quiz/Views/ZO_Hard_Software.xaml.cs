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
    /// Interaktionslogik für ZO_Hard_Software.xaml
    /// </summary>
    public partial class ZO_Hard_Software : UserControl
    {
        private Frame frame;
        public ZO_Hard_Software(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void Button_Ende(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Herzlichen Glückwunsch!\n\n"
                + "ihr habt das Quiz erfolgreich bestanden.\n\n" 
                + "\t " + "/10 richtig."); //Hier Ausgabe der richtigen Anzahl an Fragen

            Application.Current.MainWindow.Close();
        }
    }
}
