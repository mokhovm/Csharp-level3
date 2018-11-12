using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender.Model
{
    /// <summary>
    /// Статус рассылки
    /// </summary>
    public enum SendStatus
    {
        ssUnknown = 1,
        ssNew,
        ssPlanned,
        ssInProgress,
        ssDone,
        ssError
    }

    /// <summary>
    /// Рассылка
    /// </summary>
    public class MailnigListItem : CustomObject
    {
        /*
         * Отправитель
         */
        public MailUser FromUser { get; set; }
        /*
         * Получатели
         */
        public List<Customer> ToUsers { get; set; }
        /*
         * Время отправки
         */
        public DateTime Date { get; set; }
        /*
         * Текст сообщения
         */
        public string Body { get; set; }
        /*
         * Статус
         */
        public SendStatus Status { get; set; }
        /*
         * Лог системы по этой рассылке
         */
        public string Log { get; set; }

        public MailnigListItem(MailUser fromUser, List<Customer> toUsers, DateTime date, string body)
        {
            ToUsers = new List<Customer>();
            Status = SendStatus.ssNew;
            FromUser = fromUser;
            ToUsers.AddRange(toUsers);
            Date = date;
            Body = body;
        }

        /// <summary>
        /// Сохраняет данные в хранилище
        /// </summary>
        public void SaveData()
        {
            
        }

        /// <summary>
        /// Загружает данные из хранилища
        /// </summary>
        public void LoadData()
        {
            
        }

    }
}
