using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender.Model
{
    /// <summary>
    /// Пользователь почты
    /// </summary>
    public class MailUser : CustomObject
    {
        /*
         * Имя 
         */
        public string Name { get; set; }
        /*
         * Адрес 
         */
        public string Email { get; set; }

        public MailUser(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
