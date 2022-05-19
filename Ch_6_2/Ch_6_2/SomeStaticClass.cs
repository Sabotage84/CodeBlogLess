using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_6_2
{
    static class SomeStaticClass
    {
       
        static SomeStaticClass()
        {

        }

        public static void SomeMeth(int x = 5) { }

        private static string someField;

        public static string SomeField { get => someField; set => someField = value; }

        public static int SomeProp { get; set; }

        
    }
}
