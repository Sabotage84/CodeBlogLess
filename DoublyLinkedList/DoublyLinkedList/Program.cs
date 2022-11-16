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

            Console.WriteLine();

            var reverse = duplexList.Reverse();
            reverse.Show();

            Console.WriteLine();
            Console.WriteLine();

            CircularLinkedList<int> circular = new CircularLinkedList<int>(0);
            circular.Add(1);
            circular.Add(2);
            circular.Add(3);
            circular.Add(0);
            circular.Add(5);

            circular.Show();

            circular.Delete(0);
            circular.Delete(3);
            circular.Delete(5);
            circular.Show();


            Console.ReadLine();
        }
    }
}
