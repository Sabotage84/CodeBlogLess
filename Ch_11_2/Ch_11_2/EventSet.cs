using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ch_11_2
{
    public class EventKey { }// любой класс даже пустой для ключа в словаре
    class EventSet
    {
        private readonly Dictionary<EventKey, Delegate> events = new Dictionary<EventKey, Delegate>();

        public void Add(EventKey eventKey, Delegate handler)
        {
            Monitor.Enter(events);
            if (events.TryGetValue(eventKey, out var d))
            {
                events[eventKey] = Delegate.Combine(d, handler);
            }
            else
            {
                events.Add(eventKey, handler);
            }
            Monitor.Exit(events);

        }

        public void Remove(EventKey eventKey, Delegate handler)
        {
            Monitor.Enter(events);
            if (events.TryGetValue(eventKey, out var d))
            {
                d = Delegate.Remove(d, handler);
                if (d!=null)
                {
                    events[eventKey] = d;
                }
                else
                {
                    events.Remove(eventKey);
                }
            }
            Monitor.Exit(events);

        }

        public void Raise(EventKey eventKey, object sender, EventArgs e)
        {
            Monitor.Enter(events);
            if (events.TryGetValue(eventKey, out var d))
            {
                d.DynamicInvoke(new object[] { sender, e });
            }
            Monitor.Exit(events);
        }
    }
}
