using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender.Model
{
    /// <summary>
    /// Информация о сервере
    /// </summary>
    public class ServerInfo : CustomObject
    {
        /*
         * Имя сервера
         */
        public string Name { get; set; }

        /*
         * Адрес сервера
         */
        public string Address { get; set; }

        /*
         * Порт
         */
        public int Port { get; set; }

        /*
         * Логин для входа
         */
        public string Login { get; set; }

        /*
         *  Пароль для входа
         */ 
        public string Pass { get; set; }


        public ServerInfo(string name, string address, int port, string login, string pass)
        {
            Name = name;
            Address = address;
            Port = port;
            Login = login;
            Pass = pass;
        }
    }
}
