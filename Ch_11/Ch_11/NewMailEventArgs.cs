using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_11
{
    internal class NewMailEventArgs: EventArgs//второе правило реалтзовать event args и название с event args
    {
        public NewMailEventArgs(string from, string to, string subject)
        {
            From = from;
            To = to;
            Subject = subject;
        }

        public string From { get; }//первле правило поля только для чтения

        public string To { get; }

        public string Subject { get; }

        public override string ToString()//третье правило переопределить ToString
        {
            return $"Письмо от {From} для {To}: {Subject}";
        }


    }
}
