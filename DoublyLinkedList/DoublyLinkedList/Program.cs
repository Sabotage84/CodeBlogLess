using DoublyLinkedList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var duplexList = new DuplexList<int>(0);
            duplexList.Add(1);
            duplexList.Add(2);
            duplexList.Add(3);
            duplexList.Add(4);
            duplexList.Add(5);
            duplexList.Show();

            duplexList.Delete(0);
            duplexList.Show();

            duplexList.Delete(5);
            duplexList.Show();

            duplexList.Delete(3);
            duplexList.Show();


            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
