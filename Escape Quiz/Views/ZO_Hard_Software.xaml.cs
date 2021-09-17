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
            string[] software = { (string)lbBIOS.Content, (string)lbWord.Content, (string)lbOS.Content, (string)lbDrucker.Content };
            string[] hardware = { (string)lbHDD.Content, (string)lbMaus.Content, (string)lbMainboard.Content, (string)lbRAM.Content};

            Soft1.Background = Soft2.Background = Soft3.Background = Soft4.Background = wrong;
            Hard1.Background = Hard2.Background = Hard3.Background = Hard4.Background = wrong;

            int rightI = 0;
            foreach (string soft in software)
            {
                if (soft == Soft1.Text)
                {
                    Soft1.Background = right;
                    rightI++;
                }
                    
                else if (soft == Soft2.Text)
                {
                    Soft2.Background = right;
                    rightI++;
                }
                    
                else if (soft == Soft3.Text)
                {
                    Soft3.Background = right;
                    rightI++;
                }
                   
                else if (soft == Soft4.Text)
                {
                    Soft4.Background = right;
                    rightI++;

                }

            }
            foreach(string hard in hardware)
            {
                if (hard == Hard1.Text)
                {
                    Hard1.Background = right;
                    rightI++;
                }
                    
                else if (hard == Hard2.Text)
                {
                    Hard2.Background = right;
                    rightI++;
                }
                    
                else if (hard == Hard3.Text)
                {
                    Hard3.Background = right;
                    rightI++;
                }
                    
                else if (hard == Hard4.Text)
                {
                    Hard4.Background = right;
                    rightI++;
                }
                    
            }
            if (rightI == 8)
            {
                Score.OneUp();
            }

            if(clickI < 1)
            {
                MessageBox.Show("Herzlichen Glückwunsch!\n\n"
                + "ihr habt das Quiz erfolgreich bestanden.\n\n"
                + "\t  " + Score.GetScore() + " /10 richtig.\n\n"
                + "Geht nun weiter und denkt an das Lösungswort."); //Hier Ausgabe der richtigen Anzahl an Fragen
            }
            

            if(clickI > 0)
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
