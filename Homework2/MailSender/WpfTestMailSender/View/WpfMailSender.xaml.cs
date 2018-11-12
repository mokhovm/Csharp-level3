using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace WpfTestMailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            InitializeComponent();
            LogTextBox.Clear();
        }

        private void BtnSendMail_Click(object sender, RoutedEventArgs e)
        {
            // Список email
            List<string> userList = new List<string> {
                        "testEmail@gmail.com",
                        "email@yandex.ru"
                    };
            Prefs.SenderLogin = UserMail.Text;
            Prefs.SenderEmail = UserMail.Text;
            Prefs.Password = PasswordBox.Password;
            var ss = new SenderService();
            TextRange textRange = new TextRange(MsgTextBox.Document.ContentStart, MsgTextBox.Document.ContentEnd);
            if (!ss.SendToList(userList, SubjectTextBox.Text, textRange.Text, out Dictionary<string, string> report))
            {
                PrintReport(report);
            }
            AddToLog("Работа завершена.");
        }

        private void PrintReport(Dictionary<string, string> report)
        {
            string text;
            AddToLog("Отчет об отправке");
            foreach (var tuple in report)
            {
                text = tuple.Value == null ? "ok" : tuple.Value;
                AddToLog(tuple.Key + " = " + text);
            }
        }

        private void AddToLog(string msg)
        {
            LogTextBox.AppendText(msg);
            LogTextBox.AppendText(Environment.NewLine);
        }

    }

}
