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
    /// Interaction logic for EndView.xaml
    /// </summary>
    public partial class EndView : UserControl
    {
        private Frame frame;
        public EndView(Frame frame)
        {
            this.frame = frame;
            InitializeComponent();
            CodeGeneration();
            //'a' and 'z' are interpreted as ints for parameters for Next()
        }

        public void CodeGeneration()
        {
            string[] code = {"O","T", "S", "B", "M", "F", "P", "U", "Z", "A", "Q", "V", "Y", "R", "G", "I", "X", "K", "W", "C" };
            Label[] lable = { L0, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12, L13, L14, L15, L16, L17, L18, L19 }; 
            
            for (int i = 0; i <code.Length; i++)
            {
                lable[i].Content = code[i];
            }
            //'a' and 'z' are interpreted as ints for parameters for Next()
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            System.Net.WebRequest webRequest = System.Net.WebRequest.Create("http://192.168.100.9:50010/mg?game=quiz&psk=escaperoom194");
            webRequest.GetResponse();

            Application.Current.MainWindow.Close();
        }
    }
}
