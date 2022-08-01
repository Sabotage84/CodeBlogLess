using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_3
{
    sealed partial class Base//автогенирируемый класс в отдельном файле
    {
        string name;

        partial void OnNameChanged(string newName);
        

        public string Name 
        {
            get
            {
                return name;
            }

            set 
            {
                OnNameChanged(value.ToLower());
                name = value;

            }
        }
    }

    sealed partial class Base//файл класса написанный юзером, при изменении автогенерируемого этот не пропадет
    {
        partial void OnNameChanged(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                throw new ArgumentNullException(nameof(newName));
            }
        }
    }
}
