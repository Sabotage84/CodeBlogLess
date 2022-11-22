using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCodeBlog
{
    class Program
    {
        static void Main(string[] args)
        {

            EasySet<int> set1 = new EasySet<int>();

            set1.Add(1);
            set1.Add(2);
            set1.Add(2);
            set1.Add(3);
            set1.Add(4);
            set1.Add(5);
            set1.Show();


            EasySet<int> set2 = new EasySet<int>();

            set2.Add(6);
            set2.Add(7);
            set2.Add(3);
            set2.Add(4);
            set2.Show();

            EasySet<int> set3 = new EasySet<int>();

            set3 = set1.Intersection(set2);
            set3.Show();

            EasySet<int> set4 = new EasySet<int>();
            set4 = set1.Difference(set2);
            set4.Show();

            EasySet<int> set5 = new EasySet<int>();
            set5.Add(2);
            set5.Add(3);
            set5.Add(9);
            Console.WriteLine(set1.Subset(set5));

            EasySet<int> set6 = new EasySet<int>();

            set6 = set1.SymmetricDifference(set2);
            set6.Show();

            Console.ReadLine();
        }
    }
}
