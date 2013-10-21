using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson2_HW
{
    class homework
    {

       public static void task1()
        {
            int a=0, b=0, c=0;
            int outer_rec_s = 0;
            int a_rec_count = 0, b_rec_count = 0;

            int inner_rec_s = 0, remaining_rec_s = 0;

            /*.  Даны целые положительные числа A, B, C. Значение этих чисел программа  долж запрашивать    у    пользователя.    
             * На прямоугольнике    размера A *    B    размеще максимально    возможное    количество    квадратов    со стороной C.    
             * Квадраты накладываются    друг    на    друга.    Найти    количество    квадратов,    размещенн на прямоугольнике, а также площадь 
             * незанятой части прямоугольника.
                 Необходимо предусмотреть служебные сообщения в случае, если в прямоугольни
                 нельзя разместить ни одного квадрата со стороной С (например, если значение превышает размер сторон прямоугольника).*/

            Console.WriteLine("Please enter side A value:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter side B value:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter side C value:");
            c = Convert.ToInt32(Console.ReadLine());

            if ((c > a) || (c > b))
            {
                Console.WriteLine("Unable to place square in rectangle");
                return;
            }
            else
            { //if everything is fine go ahead
                outer_rec_s = a * b;

                a_rec_count = a / c;
                b_rec_count = b / c;

                inner_rec_s = (a_rec_count * c) * (b_rec_count * c);

                remaining_rec_s = outer_rec_s - inner_rec_s;

                Console.WriteLine("Outer rectangle square: {0}", outer_rec_s);
                Console.WriteLine("Inner rectangle square : {0}", inner_rec_s);
                Console.WriteLine("Remaining square : {0}", remaining_rec_s);
            }
        }

       public static void task2()
       {
           float dep_perc = 0;
           int month_count = 0;
           float new_intermid_dep = 1000;
           /*Начальный  вклад  в  банке  равен  1000  руб.  Через  каждый  месяц  размер  вкла увеличивается на P процентов от имеющейся суммы 
            * (P — вещественное число, 0 < P    Значение  Р   программа  должна   получать  у   пользователя.  По   данному
           определить, через сколько месяцев размер вклада превысит 1100 руб., и вывес найденное  количество  месяцев  K  (целое  число)  
            * и  итоговый  размер  вклада (вещественное число).
           */

           Console.WriteLine("Please enter dep percent rate:");
           dep_perc = Convert.ToSingle(Console.ReadLine());

           Console.WriteLine("You entered {0} rate", dep_perc);

           while (new_intermid_dep < 1100) 
           {
               new_intermid_dep = new_intermid_dep  + (new_intermid_dep * dep_perc / 100);

               month_count++;

         
               Console.WriteLine("Iteration num {0}", new_intermid_dep);

           }

           Console.WriteLine("month_count {0}", month_count);
           


       }

       public static void task3()
       {
           /*
            Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; 
            * при этом каждое число должно выводиться количество раз, равное его значению(например, число 3 выводится 3 раза).
            Например: если А = 3, а В = 7, то программа должна сформировать в консоли
           */
           int a = 0, b = 0;
           int i = 0, i2 = 0;

           Console.WriteLine("Please enter A value:");
           a = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Please enter B value:");
           b = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("---------------------------");

           for (i = a; i <= b; i++)
           {

               for (i2 = 0; i2 < i; i2++)
               {
                   Console.Write(i);
               }

             Console.WriteLine();

           }
           
       }

       public static void task4()
       {
           Console.WriteLine("Pleae enter a string:");
           string input = "";
           input = Console.ReadLine();

           StringBuilder sb = new StringBuilder();
           int i = input.Length - 1;

           while (i != -1)
           {
               sb.Append(input[i--]);
           }
           Console.WriteLine("Reverse:" + sb.ToString());

       }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            int task_num = 0;
          //  homework hw = new homework();

            

           
            try
            {
                Console.WriteLine("Please enter homework task number:");
                task_num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered incorrect value:");
            }


            switch (task_num)
            {

                  case 1:
                    homework.task1();
                    break;
                case 2:
                    homework.task2();
                    break;
                case 3:
                    homework.task3();
                    break;
                case 4:
                    homework.task4();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

                
            }

            

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
