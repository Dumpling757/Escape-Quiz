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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Escape_Quiz.Views
{
    /// <summary>
    /// Interaktionslogik für SymbolView.xaml
    /// </summary>
    public partial class SymbolView : UserControl
    {
        private Frame frame;

        private int clickI;

        public SymbolView(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;

        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            tbBluetooth.AllowDrop = true;
            tbLAN.AllowDrop = true;
            tbUSB.AllowDrop = true;
            tbWifi.AllowDrop = true;
        }


        private void TextBlock_DragEnter(object sender, DragEventArgs e)
        {
            // Verifiziert, dass der Inhalt des Drags nur Textartig sein kann.
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                /*
                 * Setzt den DragDropEffect auf Copy, damit der Inhalt noch im der DragSource erhalten bleibt.
                 * Damit beugt man Softlocking von Antworten vor, und gibt dem Nutzer die Möglichkeit, Antworten erneut zu verwenden.
                 */
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }

        }


        private void TextBlock_Drop(object sender, DragEventArgs e)
        {
            /*
             * Wir casten den den Sender zu einem TextBlock und verändern den Content in die Daten des DragEvents
             */
            TextBlock textBlock = (TextBlock)sender;
            textBlock.Text = (string)e.Data.GetData(DataFormats.StringFormat, true);

        }


        private void TextBlock_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            /*
             * Wir casten den Sender zu einem Label und nutzen das Label als DragSource.
             * Wir sind aber nur an der Property "Content" inderessiert und geben sie als zu kopierende Eigenschaft an.
             * Der DragDropEffect soll Copy sein, wie schon in TextBlock_DragEnter erläutert.
             */
            Label labelstring = (Label)sender;
            DragDrop.DoDragDrop(labelstring, labelstring.Content, DragDropEffects.Copy);
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            /*
             * Alle Labels und Textblöcke werden in ein Array geschrieben und eine Zähler Hilfsvariable initiiert,
             * welche die richtigen Teilantworten zählen soll
             */

            Label[] labels = { bBluetooth, bLAN, bUSB, bWLAN };

            TextBlock[] textBlocks = { tbBluetooth, tbLAN, tbUSB, tbWifi };
            int rightI = 0;

            // Es wird durch das TextBlock Array gegangen und jedes Element erstmal als "Falsch" markiert.
            // Alle Userinteraktiven Elemente werden in diesen Schleifen ebenfalls deaktiviert um User Input nach der Verfizierung zu unterbinden.
            foreach(TextBlock textBlock in textBlocks)
            {
                textBlock.Background = Score.Wrong;
                textBlock.IsEnabled = false;
            }
            
            foreach(Label label in labels)
            {
                label.IsEnabled = false;
            }

            /* Ab hier werden die Text Inhalte mit dem Label Content verglichen, wenn dies stimmen sollte,
             * wird der TextBlock visuell auf "Richtig" korrigiert und der Zähler um eins erhöht
             */
            if (tbWifi.Text == (string)bWLAN.Content)
            {
                tbWifi.Background = Score.Right;
                rightI++;
            }

            if (tbBluetooth.Text == (string)bBluetooth.Content)
            {
                tbBluetooth.Background = Score.Right; 
                rightI++;

            }


            if (tbUSB.Text == (string)bUSB.Content)
            {
                tbUSB.Background = Score.Right;

                rightI++;

            }
            if (tbLAN.Text == (string)bLAN.Content)
            {
                tbLAN.Background = Score.Right;

                rightI++;
            }

            /*
             * Wenn alle vier aufgaben richtig sind, wird der Score aktualisiert.
             */
            if (rightI == 4)
            {
                Score.OneUp();
            }

            /*
             * Erst wenn die Überprüfung fertig ist, wird der nächste Navigationsschritt getätigt, wenn der benutzer jetzt 7 Punkte hat,
             * würde das Quiz beendet werden, wenn nicht wird er zur nächsten Frage weitergeleitet.
             */
            if(clickI > 0)
            {

                if (Score.GetScore() < 7)
                    this.frame.Navigate(new SC_PrivateIP(this.frame));
                else
                    this.frame.Navigate(new EndView(this.frame));
            }
            
            // Wenn der Button geklickt wurde, wird clickI hochgezählt und der neue Content reflecktiert besser, was die Aufgabe des Buttons ist, wenn der button danach geklickt wird.
            clickI++;

            NextButton.Content = "Nächste Frage!";
        }
    }
}
