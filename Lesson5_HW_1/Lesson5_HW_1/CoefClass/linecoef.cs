using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW5
{
    class coefforline
    {

        public struct coef
        {
            public int a;
            public int b;
        }

        public static void parse(string input)
        {

            string[] parr = input.Split(';');

            try
            {

                if (parr.Length != 2)
                {
                    throw new FormatException("Incorrect number of params");
                }
                else
                {

                    coef cf;

                    cf.a = Convert.ToInt32(parr[0]);
                    cf.b = Convert.ToInt32(parr[1]);

                    Console.WriteLine("a = {0}, b = {1}", cf.a, cf.b);

                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public static string lineequation(int a1, int b1, int a2, int b2, int c1, int c2)
        {
            /*
            A1×X + B1×Y = C1
            A2×X + B2×Y = C2
            */

            int newx = 0;
            int newy = 0;
            try
            {
                newx = ((c1 * b2) - (b1 * c2)) / ((a1 * b2) - (b1 * a2));
                newy = ((a1 * c2) - (b2 * a2)) / ((a1 * b2) - (b1 * a2));

                if (((a1 * newx + b1 * newy) == c1) || (a2 * newx + b2 * newy) == c2)
                    return "Solution found: " + "\r\n" + "x = " + newx + "\r\n" + "y = " + newy;
                else
                    throw new ArgumentOutOfRangeException();

            }
            catch (ArgumentOutOfRangeException e)
            {
                return "Arguments out of range error. Message: " + e.Message + "\r\n";
            }

            catch (DivideByZeroException e)
            {
                return "Divide by zero error. Message:" + e.Message + "\r\n";
            }

        }


    }
}
