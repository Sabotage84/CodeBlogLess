using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class InstagramMessanger : MessangerBase
    {
        public InstagramMessanger(string name, string password) : base(name, password)
        {
        }

        public override bool Authorize()
        {
            Console.WriteLine($"Авторизация в Инстаграме пользователя с именем {UserName} и паролем {Password}");
            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            return new InstagramMessage(text, source, target);
        }
    }
}
