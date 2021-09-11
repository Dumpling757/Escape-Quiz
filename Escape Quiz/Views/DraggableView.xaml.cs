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
    /// Interaktionslogik für DraggableView.xaml
    /// </summary>
    public partial class DraggableView : UserControl
    {
        UIElement dragobject1 = null;
        Point offset1;
        private Frame frame;


        UIElement dragobject2 = null;
        Point offset2;

        UIElement dragobject3 = null;
        Point offset3;

        UIElement dragobject4 = null;
        Point offset4;

        public Point Location { get; set; }

        public DraggableView(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;


            Button button1 = new Button();
            button1.Content = "Woohoo!";

            Button button2 = new Button();
            button2.Content = "Button2";

            Button button3 = new Button();
            button3.Content = "Button 3";

            Button button4 = new Button();
            button4.Content = "Button 4";


            // Soll position Reset verhindern
            // button1.Click += null;
            /*
             * Button Position Shenanigans
             */
            Canvas.SetTop(button1, 0);
            Canvas.SetLeft(button1, 0);

            Canvas.SetTop(button2, 0);
            Canvas.SetLeft(button2, 0);

            Canvas.SetTop(button3, 0);
            Canvas.SetLeft(button3, 0);

            Canvas.SetTop(button4, 0);
            Canvas.SetLeft(button4, 0);


            button1.PreviewMouseDown += Button1_PreviewMouseDown;
            // button1.Click += Button1_OnClick;
            Drag1.Children.Add(button1);
            button1.Margin = new Thickness(20, 20, 0, 0);

            button2.PreviewMouseDown += Button2_PreviewMouseDown;

            Drag2.Children.Add(button2);
            button2.Margin = new Thickness(20, 40, 0, 0);

            button3.PreviewMouseDown += Button3_PreviewMouseDown;

            Drag3.Children.Add(button3);
            button3.Margin = new Thickness(20, 60, 0, 0);

            button4.PreviewMouseDown += Button4_PreviewMouseDown;

            Drag4.Children.Add(button4);
            button4.Margin = new Thickness(20, 80, 0, 0);
        }


        private void Button1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            dragobject1 = sender as UIElement;
            offset1 = e.GetPosition(Drag1);
            offset1.Y = Canvas.GetTop(dragobject1);
            offset1.X = Canvas.GetLeft(dragobject1);
            Drag1.CaptureMouse();

        }

        private void Button2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            dragobject2 = sender as UIElement;
            offset2 = e.GetPosition(Drag2);
            offset2.Y = Canvas.GetTop(dragobject2);
            offset2.X = Canvas.GetLeft(dragobject2);
            Drag2.CaptureMouse();
        }

        private void Button3_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            dragobject3 = sender as UIElement;
            offset3 = e.GetPosition(Drag3);
            offset3.Y = Canvas.GetTop(dragobject3);
            offset3.X = Canvas.GetLeft(dragobject3);
            Drag3.CaptureMouse();

        }

        private void Button4_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            dragobject4 = sender as UIElement;
            offset4 = e.GetPosition(Drag4);
            offset4.Y = Canvas.GetTop(dragobject4);
            offset4.X = Canvas.GetLeft(dragobject4);
            Drag4.CaptureMouse();

        }


        private void Drag1_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if(dragobject1 == null)
            {
                return; // safety feature
            }
            var position = e.GetPosition(sender as IInputElement);
            Canvas.SetTop(dragobject1, position.Y - offset1.Y);
            Canvas.SetLeft(dragobject1, position.X - offset1.X);

        }

        private void Drag2_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (dragobject2 == null)
            {
                return; // safety feature
            }
            var position = e.GetPosition(sender as IInputElement);
            Canvas.SetTop(dragobject2, position.Y - offset2.Y);
            Canvas.SetLeft(dragobject2, position.X - offset2.X);

        }
        private void Drag3_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (dragobject3 == null)
            {
                return; // safety feature
            }
            var position = e.GetPosition(sender as IInputElement);
            Canvas.SetTop(dragobject3, position.Y - offset3.Y);
            Canvas.SetLeft(dragobject3, position.X - offset3.X);

        }
        private void Drag4_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (dragobject4 == null)
            {
                return; // safety feature
            }
            var position = e.GetPosition(sender as IInputElement);
            Canvas.SetTop(dragobject4, position.Y - offset4.Y);
            Canvas.SetLeft(dragobject4, position.X - offset4.X);

        }

        private void Drag1_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            dragobject1 = null;
            Drag1.ReleaseMouseCapture();
        }

        private void Drag2_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

            dragobject2 = null;
            Drag2.ReleaseMouseCapture();
        }
        private void Drag3_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            dragobject3 = null;
            Drag3.ReleaseMouseCapture();
        }

        private void Drag4_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            dragobject4 = null;
            Drag4.ReleaseMouseCapture();

        }
        private void Button1_OnClick(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(dragobject1, 100);
            Canvas.SetLeft(dragobject1, 100);

        }


    }
}
