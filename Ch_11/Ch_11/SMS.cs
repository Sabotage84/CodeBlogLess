using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_11
{
    class SMS
    {
        public SMS(MailManager mm)
        {
            mm.NewMail += MmNewMail;
        }

        private void MmNewMail(object sender, NewMailEventArgs e)
        {
            Console.WriteLine("MmNewMail: "+e.To);
        }

        public void Send(string text)
        {
            Console.WriteLine("Send sms: " + text);
        }
    }
}
