using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_11_2
{
    public class FooEventArgs : EventArgs { }
    class TypeWithLotsEvents
    {
        protected EventSet EventSet { get; } = new EventSet();

        protected static readonly EventKey fooEventKey = new EventKey();

        public event EventHandler<FooEventArgs> Foo
        {
            add { EventSet.Add(fooEventKey, value); }
            remove { EventSet.Remove(fooEventKey, value); }
        }

        protected virtual void OnFoo(FooEventArgs e)
        {
            EventSet.Raise(fooEventKey, this, e);
        }

        public void SimulateFoo()
        {
            OnFoo(new FooEventArgs());
        }
    }
}
