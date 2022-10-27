using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = new Model.LinkedList<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);


            Console.ReadLine();
        }
    }
}
