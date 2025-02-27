using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    class ComplexNumbers
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumbers(double real,double imaginary)
        {
            Real = real;
            Imaginary = imaginary;

        }
        public static ComplexNumbers operator +(ComplexNumbers c1,ComplexNumbers c2)
        {
            return new ComplexNumbers(c1.Real+c2.Real,c1.Imaginary + c2.Imaginary);
        }
        public override string ToString()
        {
            return $"{Real}+i{Imaginary}";
        }
    }
}
