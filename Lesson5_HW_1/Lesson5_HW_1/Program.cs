using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW5
{
    class Program
    {

        static void Main(string[] args)
        {

            //1
            Console.WriteLine(coefforline.lineequation(2, 2, 4, 8, 0, 0));

            //2
            Console.WriteLine(coefforline.lineequation(3, -2, 1, 3, 4, 5));

            //3 - wrong solution 
            Console.WriteLine(coefforline.lineequation(0, 0, 1, 3, 4, 5));

            coefforline.parse("34;545");

            coefforline.parse("34;545;4");

          
            //-----------------------------------------------------------------------------------------------
            //Taks 5 - comparing population
            Lesson5_HW_1.Coutries.russia.moskow russia_cap = new Lesson5_HW_1.Coutries.russia.moskow();

            Lesson5_HW_1.Coutries.ukraine.kiev ukraine_cap = new Lesson5_HW_1.Coutries.ukraine.kiev();

            Lesson5_HW_1.Coutries.usa.washington usa_cap = new Lesson5_HW_1.Coutries.usa.washington();


            if (russia_cap.population > ukraine_cap.population)
            {
                Console.WriteLine("Moskow bigger than Kiev ");
            }

            if (ukraine_cap.population > usa_cap.population)
            {
                Console.WriteLine("Washington population less than Kiev");
            }
            else
            {
                Console.WriteLine("Washington population bigger than Kiev");
            }
            //-----------------------------------------------------------------------------------------------


            Console.ReadKey();
        }
    }
}
