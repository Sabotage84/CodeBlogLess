using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    public sealed class SomeClass
    {
        private class NestedClass { };

        private const int SOME_CONST_FIELD = 1;

        private readonly int someReadOnlyField = 2;

        private static int SomeStaticField = 3;

        static SomeClass()
        {

        }

        public SomeClass()
        {

        }

        public SomeClass(int x)
        {

        }

        private string InstanceMeth()
        {
            return null;
        }

        private static void StaticMeth()
        {

        }

        public void ParamsMeth(params int[] items)
        {

        }

        public int SomeProp { get; set; }

        public int SomeProperty 
        {
            get { return 0; }
            set { int a = value; }
        }

        public int this[string s]
        {
            get { return 0; }
            set { }
        }

        public EventHandler SomeDelegate;
        public event EventHandler SomeEvent;



    }

    public static class newclassStatic
    {
        public static readonly SomeClass sc;

        static newclassStatic()
        {
            sc = new SomeClass();
        }

        public static void Change()
        {
            sc.SomeProp = 5;// ридонли можно менять если это ссылочный тип
        }
    }

}
