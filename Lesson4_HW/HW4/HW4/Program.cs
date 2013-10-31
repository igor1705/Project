using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW4
{
    class Program
    {
        public static void task1()
        {
            /*1. Сжать массив,  удалив из него все 0 и заполнить освободившиеся справа элементы значениями-1*/

            int[] arr = { 2, 0, 1, 2, 0, 8 };

           
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);   
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];

                        arr[j + 1] = -1;
                    }
                }
            }

            foreach (var rec in arr)
            {
                Console.Write(rec);
            }


            Console.ReadKey();

        }

        public static void task2()
        {
            /*Преобразовать массив так, чтобы сначала шли все отрицательные элементы, А потом положительные (0 считать положительным) */

            int[] arr = { 2, 0, 7, -5, -1, 15 };
            int saved_val;

            foreach (var rec in arr)
            {
                Console.Write(rec);
            }
                        
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i ; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        saved_val = arr[i];

                        arr[i] = arr[j];
                        arr[j] = saved_val;
                    }
                }
            }
            Console.WriteLine();

            foreach (var rec in arr)
            {
                Console.Write(rec);
            }
        }


        public static void task3()
        {
            /*
            3. Написать программу, которая предлагает пользователю ввести число и считает сколько раз эточисло встречается в массиве. 
             Массив заполняется случайными числами в диапазоне от -30 до 30.
            */

            int[] myArr;
            int check_num;
            int array_rec_count=0;

            myArr = new int[50];

            //Empty array
            foreach (var rec in myArr)
            {
                Console.Write(rec);
            }

        
            Random RandomNumber1 = new Random();

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = RandomNumber1.Next(-30, 30);
            }

            Console.WriteLine();

            foreach (var rec in myArr)
            {
                Console.Write(" {0}",rec);
            }

            Console.WriteLine();


            Console.WriteLine("Please enter some int num");
            check_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: {0}", check_num);

            foreach (var rec in myArr)
            {
                if (rec == check_num) array_rec_count++;
            }
           
            Console.WriteLine("Searched value found : {0} times", array_rec_count);
            
        }


        public static void task4()
        {
            /*4. В двумерном массиве порядка M на N поменяйте местами заданные столбцы.*/
            int[,] arr = { {2, 0, 7}, {-5, -1, 15},{6, 3, 5} };

            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write("",arr[0,i]);
            }

        }

        public static void task5()
        {
            /*5. Создать метод принимающий,введенную пользователем,строку и выводящий на экран статистику по этой строке. 
             * Статистика должна включать общееколичество символов, количество букв(и сколько вверхнем регистре и нижнем), 
             * количество цифр,количество символов пунктуаци и и количество пробельныхсимволов.*/

        }

        public static void task6()
        {
            /*6.пользователь вводит строку и символ. В строке найти все вхождения этого символа и перевести его в верхний регистр,
             * а также удалить часть строки, начиная с последнего вхождения этого символа и доконца.    */

        }

        static void Main(string[] args)
        {
            int task_num = 0;

            do
            {
                try
                {
                    Console.WriteLine("Please enter homework task number, or 0 to exit");
                    task_num = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Entered incorrect value:");
                }


                switch (task_num)
                {

                    case 1:
                        task1();
                        break;

                    case 2:
                        task2();
                        break;

                    case 3:
                        task3();
                        break;

                    case 4:
                        task4();
                        break;

                    case 5:
                        task5();
                        break;

                    case 6:
                        task6();
                        break;


                    default:
                        Console.WriteLine("Default case");
                        break;


                }
                Console.ReadKey();
                Console.Clear();


            } while (task_num != 0);
        }
    }
}
