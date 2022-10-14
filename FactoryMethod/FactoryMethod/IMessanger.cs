using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IMessanger
    {
        string UserName { get; }

        string Password { get; }

        bool Connected { get; }

        IMessage CreateMessage(string text, string source, string target);

        bool Authorize();
    }
}
