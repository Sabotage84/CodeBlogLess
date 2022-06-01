using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8
{
    class Class2 : Class1
    {
        //public Class2() нельзя делать такой конструктор так как у родителя только конструкторс параметром
        //{

        //}
        public Class2(int i) : base(i)//надо так
        {
        }
    }
}
