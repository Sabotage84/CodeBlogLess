using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TestMessanger
    {
        public string UserName { get; }

        public string Password { get; }

        public bool Connected { get; }


        public TestMessanger(string name, string password)
        {
            if(!(string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(password)))
            {
                UserName = name;
                Password = password;
                Connected = ConnectToTwitter();
            }
            else
            {
                Connected=false;
            }    
        }

        public void SendMessage(string text, string source, string target)
        {
            var message = new TestMessage(text, source, target);
            SendMessageToTwitter(message);
        }

        private void SendMessageToTwitter(TestMessage message)
        {
            Console.WriteLine($"Твиттер: {message.Text}");
        }

        private bool ConnectToTwitter()
        {
            Console.WriteLine($"Авторизация в Твиттере пользователя с именем {UserName} и паролем {Password}");
            return true;
        }
    }
}
