using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = TextFileWorker.Instance;

            text1.WriteText("Hello ");
            text1.WriteText("world!!!");

            text1.Save();

        }
    }
}
