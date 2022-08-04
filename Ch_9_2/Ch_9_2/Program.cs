using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_9_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            GetVAlue(out x);
            Console.WriteLine(x);



            int y = 7;
            AddValue(ref y);
            Console.WriteLine(y);

            Dog d = new Dog("Харлей Дэвинсон");
            Console.WriteLine(d);
            ChangeDogNAme(ref d, "Харлей");
            Console.WriteLine(d);


            Dog d2;
            CreateDog(out d2);
            Console.WriteLine(d2);


            var s1 = "CODE";
            var s2 = "BLOGE";
            Console.WriteLine(s1+s2);
            Swop(ref s1, ref s2);
            Console.WriteLine(s1+s2);


            Console.ReadKey();

        }

        private static void Swop(ref object s1, ref object s2)//обжект нельзя так менять,
                                                              //передать в них не обжект не получится
        {
            var temp = s2;
            s2 = s1;
            s1 = temp;
        }

        private static void Swop<T>(ref T s1, ref T s2)
        {
            var temp = s2;
            s2 = s1;
            s1 = temp;
        }

        private static void CreateDog(out Dog d2)
        {
            d2 = new Dog("dog2");
        }

        private static void AddValue(ref int y)
        {
            y += 10;
        }

        private static void GetVAlue(out int x)
        {
            x = 10;
        }

        private static void ChangeDogNAme( ref Dog d,string s)
        {
            d = new Dog(s);
            Console.WriteLine(d);
        }
    }
}
