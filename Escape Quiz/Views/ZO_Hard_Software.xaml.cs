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

        private int clickI;

        Brush right = new SolidColorBrush(Colors.Green);
        Brush wrong = new SolidColorBrush(Colors.Red);

        public ZO_Hard_Software(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void Button_Ende(object sender, RoutedEventArgs e)
        {
            Label[] labels = { lbBIOS, lbWord, lbOS, lbDrucker, lbHDD, lbMaus, lbMainboard, lbRAM };



            TextBlock[] textBlocks = { Soft1, Soft2, Soft3, Soft4, Hard1, Hard2, Hard3, Hard4 };
            

            int rightI = 0;

            /* Doppelte ForEach Schleife geht erst durch alle TextBlock elemente und vergleicht ein einzelnes TextBlock
             * Element mit jedem Verfügbaren Label Inhalt. Wenn eine richtige Lösung gefunden wurde, wird der Zähler "rightI" erhöht.
             * Sollte der Zähler am Ende auf 8 kommen, sind alle Felder richtig ausgefüllt.
             * Sollte man bei Software oder Hardware eine Mehrfachnennung machen wird nur die erste Nennung als richtig erachtet.
             * Im ersten Methodenrumpf wird jede Feld UI erstmal auf "Falsch" gesetzt, in der inneren ForEach Schleife wird dies wieder korrigiert.
             */

            foreach (TextBlock textBlock in textBlocks)
            {
                textBlock.Background = wrong;
                foreach (Label label in labels)
                {
                    if (label.Content == textBlock.Text)
                    {
                        textBlock.Background = right;
                        rightI++;
                        label.IsEnabled = false;
                        textBlock.IsEnabled = false;
                    }
                }
            }

            

            if(clickI < 1)
            {
                MessageBox.Show("Herzlichen Glückwunsch!\n\n"
                + "ihr habt das Quiz erfolgreich bestanden.\n\n"
                + "\t  " + Score.GetScore() + " /10 richtig.\n\n"
                + "Geht nun weiter und denkt an das Lösungswort."); //Hier Ausgabe der richtigen Anzahl an Fragen
            }
            

            if(clickI > 0) 
            {
                if (rightI == 8)
                {
                    Score.OneUp();
                    
                }
                this.frame.Navigate(new EndView(this.frame));
            }
                // Application.Current.MainWindow.Close();

            clickI++;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Soft1.AllowDrop = Soft2.AllowDrop = 
                Soft3.AllowDrop =Soft4.AllowDrop = 
                Hard1.AllowDrop = Hard2.AllowDrop =
                Hard3.AllowDrop = Hard4.AllowDrop = true;

        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label labelstring = (Label)sender;
            DragDrop.DoDragDrop(labelstring, labelstring.Content, DragDropEffects.Move);

        }

        private void Label_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effects = DragDropEffects.Move;
            }
            else
            {
                // e.Effects = DragDropEffects.None;
            }
        }

        private void Label_Drop(object sender, DragEventArgs e)
        {
            TextBlock textBlock = (TextBlock)sender;
            textBlock.Text = (string)e.Data.GetData(DataFormats.StringFormat, true);
        }

        private void Label_DragLeave(object sender, DragEventArgs e)
        {

        }
    }
}
