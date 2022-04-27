using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 1);

            Console.WriteLine(p);//(1,1)  boxing так как writeline принимает ссылочный тип

            p.Change(2, 2);
            Console.WriteLine(p);//(2,2)  boxing так как writeline принимает ссылочный тип, а предыддущий уже уничтожен

            object o = p;//boxing 
            Console.WriteLine(o);//(2,2)  

            ((Point)o).Change(3, 3);//unboxing 
            Console.WriteLine(o);//(2,2) так как в o не записалось ничего, мы разбоксили сделав новый объект в стеке и потом вернулись к тому что в куче




            Console.ReadLine();
        }
    }
}
