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
    /// Interaction logic for PictureDrag.xaml
    /// </summary>
    public partial class PictureDrag : UserControl
    {
        Frame frame;
        public PictureDrag(Frame frame)
        {
            this.frame = frame;
            InitializeComponent();

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //Setzt die Eigenschaft dass Daten in das Objekt reingedropped werden dürfen
            ButtonTarget.Content = "Drop here!";

            ButtonTarget.AllowDrop = true;
            lbDrop.Visibility = Visibility.Hidden;
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label labelstring = (Label)sender;
            Label label = ButtonTarget;
            DragDrop.DoDragDrop(label, labelstring.Content, DragDropEffects.Copy);
            
        }

        private void ButtonTarget_DragEnter(object sender, DragEventArgs e)
        {
            lbDrop.Visibility = Visibility.Visible;
            
            if (e.Data.GetDataPresent(DataFormats.Text))
            {

                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                //e.Effects = DragDropEffects.None;
            }
        }

        private void ButtonTarget_DragLeave(object sender, DragEventArgs e)
        {
            // lbDrop.Visibility = Visibility.Hidden;
        }

        private void ButtonTarget_Drop(object sender, DragEventArgs e)
        {
            // lbDrop.Visibility = Visibility.Hidden;
            // 
            // TODO String wird nicht aktualisiert
            ButtonTarget.Content = (string)e.Data.GetData(DataFormats.StringFormat, true);
            ButtonTarget.Foreground = new SolidColorBrush(Colors.Green);
        }
    }
}
