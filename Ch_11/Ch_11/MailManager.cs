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
            //проверяем не равно ли е null
            _ = e ?? throw new ArgumentNullException(nameof(e));


            //могут быть проблемы с многопоточностью
            //NewMail?.Invoke(this, e);

            //вариант 2 
            //решает проблему но поведение компилятора может измениться
            var temp = NewMail;
            temp?.Invoke(this, e);

        }

        public void SimulateNewMail(string from, string to , string subject)
        {
            var e = new NewMailEventArgs(from, to, subject);


            OnNewMail(e);
        }
    }
}
