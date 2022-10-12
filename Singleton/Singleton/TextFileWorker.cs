using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class TextFileWorker
    {
        private static readonly Lazy<TextFileWorker> instance =
            new Lazy<TextFileWorker>(() => new TextFileWorker()); 

        public static TextFileWorker Instance { get { return instance.Value; }  }
        public string FilePath { get; }

        public string Text { get; private set; }

        private TextFileWorker()
        {
            FilePath = "text.txt";
            ReadTextFromFile();
        }

        public void WriteText(string text)
        {
            Text += text;
        }

        public void Save()
        {
            using (var writer = new StreamWriter(FilePath, false))
            {
                writer.Write(Text);

            }
        }


        private void ReadTextFromFile()
        {
            if (!File.Exists(FilePath))
            {
                Text = "";

            }
            else
            {
                using (var reader = new StreamReader(FilePath))
                {
                    Text = reader.ReadToEnd();

                }
            }
        }
    }
}
