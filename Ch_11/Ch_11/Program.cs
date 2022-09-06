using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var mm = new MailManager();
            //первый способ подписки
            mm.NewMail += MailManagerNewMail;
            //второй способ
            var sms = new SMS(mm);
            //третий способ
            var p = new Printer();
            mm.NewMail += p.PrNewMail;

            mm.SimulateNewMail("I", "You", "Shit");
            Console.ReadLine();
        }

        private static void MailManagerNewMail(object sender, NewMailEventArgs e)
        {
            //var sms = new SMS();
            //sms.Send(e.Subject);

            var printer = new Printer();
            printer.Print(e.From);
        }
    }
}
