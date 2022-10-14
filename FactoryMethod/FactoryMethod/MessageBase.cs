using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class MessageBase : IMessage
    {
        public string Text { get; protected set; }

        public string Target { get; }

        public string Source { get; }

        public MessageBase(string text, string source, string target)
        {

            #region Проверяем входные данные на валидность
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text), "Текст сообщения не может быть пустым.");
            }
            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source), "Имя отправителя не может быть пустым.");
            }
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(target), "Имя получателя не может быть пустым.");
            }
            //if (text.Length > 140)
            //{
            //    throw new ArgumentException(nameof(text), "Текст не может быть больше 140 символов.");
            //}

            #endregion
            Text = text;
            Source = source;
            Target = target;
        }

        public abstract void Send();
       
    }
}
