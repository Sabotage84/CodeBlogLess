using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4
{
    class Manager:Employee
    {
        static public string name;

        public Manager()
        {

        }

        public Manager(string _name)
        {
            name = _name;
        }

        public Manager(int b)
        {
            this.a = b;
        }

        public override void CallEpmloyee()
        {
            Console.WriteLine("Call Manager!");
        }

        new public void foo()
        {
            Console.WriteLine("Manager class55!");
        }
    }
}
