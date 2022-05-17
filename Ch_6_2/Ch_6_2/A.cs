using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_6_2
{
    class A
    {
        protected int i = 0;

        public virtual void Update()
        {
            i++;
            Console.WriteLine(i);

        }

        //abstract public void TestAbstract(int x);
        
    }
}
