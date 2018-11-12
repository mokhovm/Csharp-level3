using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender
{
    /// <summary>
    /// Класс позволяет осуществлять отправку писем
    /// </summary>
    class SenderService
    {
        /// <summary>
        /// Отправляет письмо
        /// </summary>
        /// <param name="MailMsg"> экземпляр письма</param>
        /// <returns>вернет null, если всё хорошо или текст ошибки</returns>
        public string Send(MailMessage MailMsg)
        {
            string res = null;
            using (SmtpClient sc = new SmtpClient(Prefs.SMTP_SERVER, Prefs.SMTP_PORT))
            {
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential(Prefs.SenderLogin, Prefs.Password);
                try
                {
                    sc.Send(MailMsg);
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
            }
            return res;
        }

        /// <summary>
        /// Рассылает письма списку рецепиентов
        /// </summary>
        /// <param name="recepientList">Список адресов получателей</param>
        /// <param name="subject">тема письма</param>
        /// <param name="body">содержание письма</param>
        /// <param name="report">Статистика по рассылке. Если значением ключа является null, то проблем с отправкой не было</param>
        /// <returns>Вернет тру, если почта всем адресатам успешно отправлена</returns>
        public bool SendToList(List<string> recepientList, string subject, string body, out Dictionary<string, string> report)
        {
            bool res = true;
            report = new Dictionary<string, string>();
            foreach (string toEmail in recepientList)
            {
                // Используем using, чтобы гарантированно удалить объект MailMessage после использования
                using (MailMessage mm = new MailMessage(Prefs.SenderEmail, toEmail, subject, body))
                {
                    mm.IsBodyHtml = false; // Не используем html в теле письма
                    report[toEmail] = Send(mm);
                    res &= report[toEmail] == null;
                }
            }
            return res;

        }
    }
}
