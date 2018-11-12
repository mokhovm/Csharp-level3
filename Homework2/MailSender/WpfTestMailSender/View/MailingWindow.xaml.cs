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
using System.Windows.Shapes;
using WpfTestMailSender.View;

namespace WpfTestMailSender
{
    /// <summary>
    /// Логика взаимодействия для MailingWindow.xaml
    /// </summary>
    public partial class MailingWindow : Window
    {
        public MailingWindow()
        {
            InitializeComponent();
            Model.MailingList.AddTestData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var win2 = new ServerInfoEditorWindow();
            win2.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var win2 = new CustomerEditorWindow();
            win2.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            var win2 = new MailingEditorWindow();
            win2.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            var win2 = new ServerInfoEditorWindow();
            win2.Show();
        }
    }
}
