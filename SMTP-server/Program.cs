using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

class SMTPServer
{
    static void Main(string[] args)
    {
        MailMessage mail = new MailMessage();
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        Console.Write("Введите адрес отправителя: ");
        string email_sender = Console.ReadLine();

        Console.Write("Введите адрес отправителя: ");
        string email_recipient = Console.ReadLine();

        Match match_sen = regex.Match(email_sender);
        Match match_rec = regex.Match(email_recipient);
        if (match_sen.Success && match_rec.Success)
        {
            mail.From = new MailAddress(email_sender); // Адрес отправителя
            mail.To.Add(new MailAddress(email_recipient)); // Адрес получателя
            mail.Subject = "Header";
            mail.Body = "This is a test message (C#)";

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.yandex.ru";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("email", "password");
            client.Send(mail);
        } else
        {
            Console.WriteLine("Неверный email!");
        }
    }
}