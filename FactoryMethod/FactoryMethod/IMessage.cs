using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IMessage
    {
        string Text { get; }
    
        string Target { get; }

        string Source { get; }

        void Send();
    } 
} 