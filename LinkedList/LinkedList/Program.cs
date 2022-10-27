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
            var lst = new Model.LinkedList<string>();
            lst.Add("1");
            lst.Add("2");
            lst.Add("3");
            lst.Add("4");
            lst.Add("5");
            lst.Add("6");
            lst.Add("7");
            lst.Show();
            lst.Delete("5");
            lst.Show();
            lst.Delete("9");
            lst.Show();
            lst.Delete("1");
            foreach (var item in lst)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
