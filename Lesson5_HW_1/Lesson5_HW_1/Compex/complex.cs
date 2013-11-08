using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson5_HW_1.Compex
{
    class complex
    {
        private int i;
        public double A;
        public double B;

        public complex(double a, double b)
        {
            A = a;
            B = b;
            i = 1;
        }

              
        public override string ToString()
        {
            if (this.A == 0 && this.B == 0)
            {
                return String.Format("0");
            }
            else
            {
                return String.Format("{0} + {1} * i^{2}", this.A, this.B, i);
            }
        }
       

        //Overloading operators...
        
        public static complex operator *(complex c, complex c1)
        {
            return new complex(c.A * c1.A, c.B * c.B);
        }
        public static complex operator *(double i, complex c)
        {
            return new complex(c.A * i, c.B * i);
        }
        public static complex operator -(complex c, double i)
        {
            return new complex(c.A - 1, c.B - i);
        }
        public static complex operator -(complex c, complex c1)
        {
            return new complex(c.A - c1.A, c.B - c1.B);
        }
        public static complex operator /(complex c, complex c1)
        {
            return new complex(c.A / c1.A, c.B / c.B);
        }


    }
}
