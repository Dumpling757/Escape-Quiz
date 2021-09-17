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
    /// Interaktionslogik für SymbolView.xaml
    /// </summary>
    public partial class SymbolView : UserControl
    {
        private Frame frame;

        private int clickI;

        private Brush right =new SolidColorBrush(Colors.Green);
        private Brush wrong = new SolidColorBrush(Colors.Red);
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
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }

        }


        private void TextBlock_Drop(object sender, DragEventArgs e)
        {
            TextBlock textBlock = (TextBlock)sender;
            textBlock.Text = (string)e.Data.GetData(DataFormats.StringFormat, true);

        }

        
        private void TextBlock_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label labelstring = (Label)sender;
            DragDrop.DoDragDrop(labelstring, labelstring.Content, DragDropEffects.Copy);
        }

        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            Label[] labels = {bBluetooth, bLAN, bUSB, bWLAN };

            TextBlock[] textBlocks = { tbBluetooth, tbLAN, tbUSB, tbWifi };
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
                foreach(Label label in labels)
                {
                    if(label.Content == textBlock.Text)
                    {
                        textBlock.Background = right;
                        rightI++;
                    }
                }
            }

            if (rightI == 4)
            {
                Score.OneUp();
            }
                

            if (clickI > 0)
            {
                this.frame.Navigate(new SC_PrivateIP(this.frame));

            }
            clickI++;
        }
    }
}
