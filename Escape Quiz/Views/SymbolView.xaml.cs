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
            int rightI = 0;
            tbWifi.Background = wrong;
            tbUSB.Background = wrong;
            tbLAN.Background = wrong;
            tbBluetooth.Background = wrong;

            if(tbWifi.Text == (string)bWLAN.Content)
            {
                tbWifi.Background = right;
                rightI++;
            }

            if (tbBluetooth.Text == (string)bBluetooth.Content)
            {
                tbBluetooth.Background = right;
                rightI++;

            }

            if (tbUSB.Text == (string)bUSB.Content)
            {
                tbUSB.Background = right;
                rightI++;

            }

            if (tbLAN.Text == (string)bLAN.Content)
            {
                tbLAN.Background = right;
                rightI++;

            }

            if (rightI == 4)
                Score.OneUp();

            if (clickI > 0)
            {
                this.frame.Navigate(new SC_PrivateIP(this.frame));

            }
            clickI++;
        }
    }
}
