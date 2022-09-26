using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_12_5
{
    public class Class3<TClass>
    {
        public void Meth1<TMeth>(TMeth arg1, TClass arg2)
        {
            Console.WriteLine(arg1.ToString() + arg2.ToString()); 
        }
    }
}
