using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dich2 = System.Collections.Generic.List<
            System.Collections.Generic.Dictionary<
                System.Collections.Generic.Dictionary<int,string>, 
            System.Collections.Generic.Dictionary<char, System.IO.Stream>>>;

namespace Ch_12_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            List<string> lst2 = new List<string>();
            //  public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>

            var d1 = new Dictionary<string, Guid>();//эти типы несовместимы
            var d2 = new DictionaryString<Guid>();//так как разное наследование 


            //если есть такая колбаса
            //List<Dictionary<Dictionaryint,string>, Dictionary<char, Stream>>>
            //проще сделать класс смотри dich
            //и уже использовать так
            Dich d3 = new Dich();
            //но так может возникнуть проблемы с совместимостью
            //поэтому лучше использовать using

            //инвариантность - никаких других кроме указанного
            //контрвариантность - любой наследник
            //ковариантность любой предок

            Deleg<Child, Child, Child> item = null;

            Deleg<GrandChild, Base, Child> item2 = null;

            item2 = item;

            Class3<int> temp = new Class3<int>();

            temp.Meth1<string>("str", 22);
            Console.ReadLine();
        }

        public class Dich : List<Dictionary<Dictionary<int, string>, Dictionary<char, Stream>>>
        { 
        }

        public class Base { }

        public class Child:Base
        {

        }

        public class GrandChild:Child
        {

        }
        public delegate TResult Deleg<in TArg, out TResult, TStandart>(TArg arg);
    }
}
