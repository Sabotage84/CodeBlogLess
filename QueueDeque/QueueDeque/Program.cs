using QueueDeque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDeque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var q = new LinkedQueue<int>(1);
         
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);

           
            q.Show();
            Console.WriteLine(q.Dequeue());
            q.Show();
            Console.WriteLine(q.Dequeue());

            q.Show();
            Console.WriteLine(q.Dequeue());
            q.Show();
            Console.WriteLine(q.Dequeue());
            q.Show();
            Console.WriteLine(q.Dequeue());
            q.Show();

            Console.ReadLine();

        }
    }
}
