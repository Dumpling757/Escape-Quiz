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
    /// Interaction logic for MultipleChoice.xaml
    /// </summary>
    public partial class MultipleChoiceView : UserControl
    {
        private Frame frame;
        public MultipleChoiceView(Frame frame)
        {
            
            InitializeComponent();

            this.frame = frame;
        }
    }
}
