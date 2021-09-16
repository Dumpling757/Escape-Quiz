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
                // e.Effects = DragDropEffects.None;
            }

        }

        private void tbBluetooth_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                // e.Effects = DragDropEffects.None;
            }

        }

        private void tbWifi_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                // e.Effects = DragDropEffects.None;
            }

        }

        private void tbLAN_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                // e.Effects = DragDropEffects.None;
            }

        }

        private void tbUSB_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                // e.Effects = DragDropEffects.None;
            }

        }

        private void tbUSB_Drop(object sender, DragEventArgs e)
        {
            TextBlock textBlock = tbUSB;
            textBlock.Text = (string)e.Data.GetData(DataFormats.StringFormat, true);

        }

        private void tbLAN_Drop(object sender, DragEventArgs e)
        {
            TextBlock textBlock = tbLAN;
            textBlock.Text = (string)e.Data.GetData(DataFormats.StringFormat, true);

        }

        private void tbWifi_Drop(object sender, DragEventArgs e)
        {
            TextBlock textBlock = tbWifi;
            textBlock.Text = (string)e.Data.GetData(DataFormats.StringFormat, true);

        }

        private void tbBluetooth_Drop(object sender, DragEventArgs e)
        {
            
            TextBlock textBlock = tbBluetooth;
            textBlock.Text = (string)e.Data.GetData(DataFormats.StringFormat, true);

        }

        private void tbBluetooth_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void tbWifi_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void tbLAN_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void tbUSB_DragLeave(object sender, DragEventArgs e)
        {

        }



        private void bWLAN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label labelstring = (Label)sender;
            TextBlock textBlock = tbWifi;
            DragDrop.DoDragDrop(textBlock, labelstring.Content, DragDropEffects.Copy);
        }

        private void bBluetooth_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label labelstring = (Label)sender;
            TextBlock textBlock = tbBluetooth;
            DragDrop.DoDragDrop(textBlock, labelstring.Content, DragDropEffects.Copy);

        }

        private void bLAN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label labelstring = (Label)sender;
            TextBlock textBlock = tbLAN;
            DragDrop.DoDragDrop(textBlock, labelstring.Content, DragDropEffects.Copy);

        }

        private void bUSB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label labelstring = (Label)sender;
            TextBlock textBlock = tbUSB;
            DragDrop.DoDragDrop(textBlock, labelstring.Content, DragDropEffects.Copy);

        }


        private void Button_NextQuestion(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new SC_PrivateIP(this.frame));
        }
    }
}
