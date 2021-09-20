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
// using Views;

namespace Escape_Quiz
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            

            InitializeComponent();
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            
        }

        

        private void Button_QuizStart(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("IT Quiz - Get Help.\n\n" +
                 "Willkommen im Escape Room der FI194. Wie wir sehen, habt ihr den Einstieg erfolgreich geschafft, " +
                 "den PC repariert und den USB Stick gefunden. \n\n" +
                 "Eure Aufgabe ist es nun, dieses Quiz mit Themen rund um die Informationstechnologie zu bestehen, " +
                 "um einen benötigten Code für die nächste Station zu erhalten. \n\n" +
                 "HINWEIS\n" +
                 "Sei aufmerksam, denn zurückgehen kannst du nicht! \n\n" +
                 "Und nun: VIEL SPAß!");

            this.MainFrame.Navigate(new Views.Wahrheitswerttabelle(this.MainFrame));
           
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
