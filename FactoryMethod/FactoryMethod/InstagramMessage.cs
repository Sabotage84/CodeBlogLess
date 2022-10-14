using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class InstagramMessage:MessageBase
    {
        public InstagramMessage(string text, string source, string target) : base(text, source, target)
        {
            if(File.Exists(text))
            {
                var imageBytes = File.ReadAllBytes(text);
                var base64String = Convert.ToBase64String(imageBytes);
                Text = base64String;
            }
        }

        public override void Send()
        {
            Console.WriteLine($"Инстаграм: {Text}");
        }

    }
}
