using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender
{
    public static class Prefs
    {
        public const string SMTP_SERVER = "smtp.mail.ru";
        public const int SMTP_PORT = 25;


        public static string SenderLogin = "sender@yandex.ru";
        public static string SenderEmail = SenderLogin;
        public static string Password = "";


    }
}
