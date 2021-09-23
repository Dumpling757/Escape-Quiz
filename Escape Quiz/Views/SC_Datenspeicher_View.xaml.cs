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
    /// Interaktionslogik für SC_Datenspeicher_View.xaml
    /// </summary>
    public partial class SC_Datenspeicher_View : UserControl
    {
        private Frame frame;
        private int clickI;
        public SC_Datenspeicher_View(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {

            // Alle User Interktiven Elemente werden deaktiviert und erstmal auf Falsch gesetzt.


            Zahl.Foreground = Score.Wrong;
            Zahl.IsEnabled = false;

            Bild.Foreground = Score.Wrong;
            Bild.IsEnabled = false;
            Geräusch.Foreground = Score.Wrong;
            Geräusch.IsEnabled = false;
            Wort.Foreground =  Score.Wrong;
            Wort.IsEnabled = false;
            Software.Foreground = Score.Wrong;
            Software.IsEnabled = false;

            if ((bool)Zahl.IsChecked)
                Zahl.Foreground = Score.Right;



            /*
             * Erst wenn die Überprüfung fertig ist, wird der nächste Navigationsschritt getätigt, wenn der benutzer jetzt 7 Punkte hat,
             * würde das Quiz beendet werden, wenn nicht wird er zur nächsten Frage weitergeleitet.
             */

            if (clickI > 0)
            {
                if ((bool)Zahl.IsChecked)                
                    Score.OneUp();

                if (Score.GetScore() < 7)
                    this.frame.Navigate(new Freitext1View(this.frame));
                else
                    this.frame.Navigate(new EndView(this.frame));
                
            }

            // Wenn der Button geklickt wurde, wird clickI hochgezählt und der neue Content reflecktiert besser, was die Aufgabe des Buttons ist, wenn der button danach geklickt wird.

            clickI++;
            ButtonNext.Content = "Nächste Frage";
        }
    }
        
    }
