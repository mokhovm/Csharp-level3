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

namespace WpfTestMailSender.Controls
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class LabeledTextBox : UserControl
    {
        private string _localLabel = "enter label caption";
        private string _localTextBox = "enter text";

        public LabeledTextBox()
        {
            InitializeComponent();
        }

        public string Label
        {
            get { return _localLabel; }
            set
            {
                _localLabel = value;
                BaseLabel.Content = value;
            }
        }

        public string TextBox
        {
            get { return _localTextBox; }
            set
            {
                _localTextBox = value;
                BaseTextBox.Text = value;
            }
        }
    }
}
