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

            Console.WriteLine("______________________________________");

            var dq = new DuplexLinkedDeque<int>();
            
            dq.Show();

            dq.PushFront(1);
            dq.PushFront(2);
            dq.PushFront(3);
            dq.PushFront(4);
            dq.Show();
            dq.PushBack(5);
            dq.PushBack(6);
            dq.PushFront(7);
            dq.PushFront(8);
            dq.Show();

            dq.PopBack();
            dq.Show();

            dq.PopFront();
            dq.Show();
            dq.PopFront(); dq.PopFront(); dq.PopFront(); dq.PopFront(); dq.PopFront(); dq.PopFront();



            Console.ReadLine();

        }
    }
}
