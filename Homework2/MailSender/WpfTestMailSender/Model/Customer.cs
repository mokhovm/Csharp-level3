using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender.Model
{
    /// <summary>
    /// Клиент компании
    /// </summary>
    public class Customer : MailUser
    {
        /*
        * Дата рождения
        */
        public DateTime Dob { get; set; }
        /*
         * Телефон
         */
        public string Phone { get; set; }
        /*
         * Адрес 
         */
        public string Address { get; set; }

        public Customer(string name, string email, DateTime dob, string phone, string address) : base(name, email)
        {
            Dob = dob;
            Phone = phone;
            Address = address;
        }
    }
}
