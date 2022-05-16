﻿using System;
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

        public EventHandler SomeEvent;
    }
}
