using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkArr
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание№1");
            double[] arr1 = new double[6];
            Random rand = new Random();

            arr1[0] = 0;
            Console.WriteLine("Массив:");
            Console.WriteLine(arr1[0]);
            for (int i = 1; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(15) + rand.NextDouble();
             //   arr1[4] = 0;
                Console.WriteLine(arr1[i]);
            }



            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == 0)
                {
                    for (int x = i; x < arr1.Length - 1; x++)
                    {
                        arr1[x] = arr1[x + 1];
                    }

                    arr1[arr1.Length - 1] = -1;
                }


            }

            Console.WriteLine("Массив после сжатия:");
            for (int i = 0; i < arr1.Length; i++)
            {

                Console.WriteLine(arr1[i]);
            }


            Console.WriteLine("Задание№2");

            int[] arr2 = new int[10];
            int dop = 0;
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(-15,15);
                Console.WriteLine(arr2[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < 0)
                {
                    dop = arr2[i];
                    for (int x = i; x > 0 ; x--)
                    {
                        arr2[x] = arr2[x - 1];
                    }
                    arr2[0] = dop;
                }
            }
            Console.WriteLine("Массив после преоброзования:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }


            Console.WriteLine("Задание№3");
            int[] arr3 = new int[10];
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = rand.Next(15);
                Console.WriteLine(arr3[i]);
            }

            Console.WriteLine("Введите число:");
            var num = double.Parse(Console.ReadLine());
            int dop3 = 0;
            for(int i = 0;i < arr3.Length; i++)
            {
                if(arr3[i] == num)
                {
                    dop3++;
                }

            }
            Console.WriteLine("Число {0} встречается {1} {2}", num, dop3, "раз");
        }
    }
}
