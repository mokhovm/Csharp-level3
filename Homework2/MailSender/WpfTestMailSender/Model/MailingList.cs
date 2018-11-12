using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender.Model
{
    public static class MailingList
    {
        static Random rnd = new Random();
        public static List<MailnigListItem> MainMailnigList = new List<MailnigListItem>();
        public static List<Customer> CustomerList = new List<Customer>();
        public static List<MailUser> UserList = new List<MailUser>();
        public static List<ServerInfo> ServerList = new List<ServerInfo>();

        public static void AddTestData()
        {

            ServerList.Add(new ServerInfo("yandex", "smtp.yandex.ru", 25, "myyandex", "myyandex"));
            ServerList.Add(new ServerInfo("mail", "smtp.mail.ru", 25, "mail", "mail"));

            UserList.Add(new MailUser("Sender1", "sender1@yandex.ru"));
            UserList.Add(new MailUser("Sender2", "sender1@mail.ru"));

            CustomerList.Add(new Customer("Иванов", "ivanov@mail.ru", DateTime.Now, "+7 900 800-90-60", "Москва, Шабловка 37"));
            CustomerList.Add(new Customer("Петров", "petrov@mail.ru", DateTime.Now, "+7 100 777-12-50", "Санкт-Петербург, Шпалерная 2-12"));
            CustomerList.Add(new Customer("Сидоров", "sidorov@mail.ru", DateTime.Now, "+7 200 888-22-40", "Сочи, Демократическая 10"));
            CustomerList.Add(new Customer("Захаров", "zaharov@mail.ru", DateTime.Now, "+7 300 999-45-30", "Воронеж, Луначарского 24 - 80"));
            CustomerList.Add(new Customer("Егоров", "egorov@mail.ru", DateTime.Now, "+7 400 222-67-20", "Вологда, Рабочая 4 - 20"));
            CustomerList.Add(new Customer("Шатц", "schatz@mail.ru", DateTime.Now, "+7 500 333-88-10", "Новосибирск, Московская 9"));


            MainMailnigList.Add(new MailnigListItem(GetRandomUser(), GetRandomCustomerList(), DateTime.Today, "hello"));
            MainMailnigList.Add(new MailnigListItem(GetRandomUser(), GetRandomCustomerList(), DateTime.Today, "hello"));
            MainMailnigList.Add(new MailnigListItem(GetRandomUser(), GetRandomCustomerList(), DateTime.Today, "hello"));
            MainMailnigList.Add(new MailnigListItem(GetRandomUser(), GetRandomCustomerList(), DateTime.Today, "hello"));
            MainMailnigList.Add(new MailnigListItem(GetRandomUser(), GetRandomCustomerList(), DateTime.Today, "hello"));

        }

        static MailUser GetRandomUser()
        {
            return UserList[rnd.Next(UserList.Count)];
        }

        static Customer GetRandomCustomer()
        {
            return CustomerList[rnd.Next(CustomerList.Count)];
        }

        static List<Customer> GetRandomCustomerList()
        {
            var res = new List<Customer>();
            var qty = rnd.Next(1, CustomerList.Count);
            for (int i = 0; i < qty; i++)
            {
                res.Add(CustomerList[rnd.Next(CustomerList.Count)]);

            }
            return res;
        }
    }
}
