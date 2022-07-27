using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_2
{
    class Complex
    {
        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public double Re { get; }
        public double Im { get; }

        public static Complex operator + (Complex c1, Complex c2)
        {
            return new Complex(c1.Re + c2.Re, c1.Im + c2.Im);
        }

        public static Complex Add(Complex c1, Complex c2)
        {
            return c1 + c2;
        }

        public Complex(int re)
        {
            Re = re;
            Im = 0;
        }

        public int ToInt()
        {
            return (int)Re;
        }

        public override string ToString()
        {
            return Re+" + i"+ Im;
        }
    }
}
