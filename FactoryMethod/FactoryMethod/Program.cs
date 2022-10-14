using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var messanger = new TestMessanger("Ivan", "Pass");
            messanger.SendMessage("Hello, Twitter", "Ivan", "Pavel");


            var twitter = new TwitterMessanger("Ivan", "Pass");
            var twit = twitter.CreateMessage("Hello FACTORY METHOD!", "Ivan", "Oleg");
            twit.Send();

            var instagram = new InstagramMessanger("Mary", "Pass2");
            var photo = instagram.CreateMessage("test.jpg", "MAry", "Ivan");
            photo.Send();

            Console.ReadLine();
        }
    }
}
