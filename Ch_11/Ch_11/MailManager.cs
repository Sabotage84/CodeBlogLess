using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_11
{
    internal class MailManager
    {
        public event EventHandler<NewMailEventArgs> NewMail;

        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            NewMail?.Invoke(this, e);
        }

        public void SimulateNewMail(string from, string to , string subject)
        {

        }
    }
}
