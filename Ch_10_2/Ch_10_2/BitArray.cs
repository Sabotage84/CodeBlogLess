using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_10_2
{
    public sealed class BitArray
    {
        private byte[] byteArray;
        private int bitNumber;

        public BitArray(int bitNumber)
        {
            this.bitNumber = bitNumber;
            byteArray = new byte[(bitNumber+7)/8];

        }

        public bool this[int number]//задается типа индексатор как свойство, при обращении к классу по квадратным
                                    //скобкам получим то что в ГЕТ
        {
            set
            {
                if(value)
                {
                    byteArray[number / 8] = (byte)(byteArray[number / 8] | (1 << (number % 8)));
                }
                else
                {
                    byteArray[number / 8] = (byte)(byteArray[number / 8] | ~(1 << (number % 8)));
                }
            }
            get
            {
                return (byteArray[number / 8] & (1 << (number % 8))) != 0;
            }
        }
    }
}
