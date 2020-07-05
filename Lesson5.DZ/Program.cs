using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №12

            int[] arrA = new int[5] { 14, 28, 30, 45, 56 };

            Console.WriteLine("Введите номер индекса:");

            string Iinput = Console.ReadLine();
            int i = int.Parse(Iinput);

            Console.WriteLine(arrA[i]);

            Console.WriteLine("Введите 1 чтобы перейти к следующему заданию");

            string YesOrNo = Console.ReadLine();
            int YesNo = int.Parse(YesOrNo);

            if (YesNo == 1)
            {
                Console.Clear();
                goto NextTaskOne;
            }
            if (YesNo == 2)
            {
                Console.WriteLine("Пока)");
            }

        NextTaskOne:
            {
                // Задание №79

                int[] arr = new int[28] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 1, 4, 3, 5, 4, 4, 4, 3, 4, 5, 4, 3, 4, 5, 3, 3, 1 };
                int count = 0, I = 0;
                while (I < arr.Length && arr[I] == 2)
                {
                    count++;
                    i++;
                }
                Console.WriteLine(i + " двойка");

                Console.WriteLine("Введите 1 чтобы перейти к следующему заданию");

                string YesOrNo1 = Console.ReadLine();
                int YesNo1 = int.Parse(YesOrNo);

                if (YesNo1 == 1)
                {
                    Console.Clear();
                    goto NextTaskTwo;
                }
                if (YesNo1 == 2)
                {
                    Console.WriteLine("Пока)");
                }
            NextTaskTwo:
                {
                    // Задание №1

                    int[] array = new int[8] { 37, 0, 50, 46, 34, 46, 0, 13 };

                    Console.WriteLine(array[0]);
                    Console.WriteLine(array[1]);
                    Console.WriteLine(array[2]);
                    Console.WriteLine(array[3]);
                    Console.WriteLine(array[4]);
                    Console.WriteLine(array[5]);
                    Console.WriteLine(array[6]);
                    Console.WriteLine(array[7]);

                    Console.WriteLine("Введите 1 чтобы перейти к следующему заданию");

                    string YesOrNo2 = Console.ReadLine();
                    int YesNo2 = int.Parse(YesOrNo);

                    if (YesNo1 == 1)
                    {
                        Console.Clear();
                        goto NextTaskThree;
                    }
                    if (YesNo1 == 2)
                    {
                        Console.WriteLine("Пока)");
                    }
                }



            NextTaskThree:
                {
                    // Задание №9

                    var rnd = new Random();
                    var randomArray = Enumerable.Range(1, 20).OrderBy(x => rnd.Next(-1, 2)).ToArray();
                    Console.WriteLine(string.Join(" ", randomArray));

                    Console.WriteLine("Введите 1 чтобы перейти к следующему заданию");

                    string YesOrNo2 = Console.ReadLine();
                    int YesNo2 = int.Parse(YesOrNo);

                    if (YesNo1 == 1)
                    {
                        Console.Clear();
                        goto NextTaskFour;
                    }
                    if (YesNo1 == 2)
                    {
                        Console.WriteLine("Пока)");
                    }
                }
            NextTaskFour:
                {
                    // Задание №

                    int n = Convert.ToInt32(Console.ReadLine());
                    Random r = new Random();
                    int[] mass = new int[n];
                    for (int L = 0; L < mass.Length; L++)
                    {
                        mass[L] = r.Next(-10, 10);
                        Console.WriteLine(mass[i]);
                    }
                    int j = 1;
                    while (j < n)
                    {
                        Console.WriteLine("element {0}: index {1}", mass[j], j);
                        j *= 2;
                    }
                 } 
               }
            }
         }
      }
  


    

