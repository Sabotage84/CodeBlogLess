using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_11
{
    class Printer
    {
        public void Print(string text)
        {
            Console.WriteLine("Printer: "+text);
        }

        public void PrNewMail(object sender, NewMailEventArgs e)
        {
            Console.WriteLine("PrNewMail: " + e.To);
        }

        public Printer(MailManager mm)
        {
            mm.NewMail += OnNewMailEvent;
        }

        private void OnNewMailEvent(object sender, NewMailEventArgs e)
        {
            Console.WriteLine("OnNewMailEvent called");
        }

        public void Unredister(MailManager mm)
        {
            mm.NewMail -= OnNewMailEvent;
        }
    }
}
