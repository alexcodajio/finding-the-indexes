using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace massiv1
{
    class Program
    {
        static int findsumofindexes(int a)
        {
            if (a < 10) return a;
            int digit = a % 10;
            int nextValue = a / 10;
            return digit + findsumofindexes(nextValue);
        }
        public static int StoringtheSumnumber()
        {
            Console.Write("введите искомое целое число sum:");
            int sum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\nВы ввели {sum1}");
            return sum1;
        }
        static int[] MakeArray()
        {
            Console.Write("\n\nВведите длину массива чисел:");
            int arrleng = int.Parse(Console.ReadLine());
            int[] zzz = new int[arrleng];
            for (int i = 0; i < arrleng; i++)
            {
                zzz[i] = int.Parse(Console.ReadLine());
            }
            return zzz;
        }
        static int[] showArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = findsumofindexes(a[i]);
            }
            return a;
        }
        static int[] gettingIndexes(int[] a, int sum1, int count, int rejects) {
            for (int l = 0; l < a.Length; l++)
            {
                if (a[l] == sum1)
                {
                    ++count;
                    Console.Write(l + "\t");
                }
                else rejects++;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("В Функциональном стиле");
            int sum1 = StoringtheSumnumber();

            int[] arraycreated = MakeArray();
            Console.WriteLine("\n\nВведенные числа:" + "\n");
            for (int k = 0; k < arraycreated.Length; k++)
            {
                Console.Write(arraycreated[k] + "\t");
            }
            int[] transformedarray = showArray(arraycreated);
            Console.Write("\n\nИсходный Массив чисел состоящией из сумы собственных составных индексов чисел относительно оригинального: " + "\n");
            for (int i = 0; i < transformedarray.Length; i++)
            {
                Console.Write(transformedarray[i] + "\t");
            }
            int count1 = 0;
            int rejects1 = 0;

            int[] indexshow = gettingIndexes(transformedarray, sum1, count1, rejects1);
            Console.Write($"\n\n Индексы исходного массива сумма составных индексов числа которых равняется {sum1}-ти" + "\n");
            for (int l = 0; l < indexshow.Length; l++) { 
            if (indexshow[l] == sum1)
            {
                ++count1;

                Console.Write(l + "\t");
            }

            else rejects1++;
        }
            Console.WriteLine($"\n\nКоличество совпадний:{count1}");
            Console.WriteLine($"\n\nКоличество несовпавших:{rejects1}");
            Console.WriteLine("\n\n после функции");
            Console.Write("введите искомое целое число sum:");
       
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\nВы ввели {sum}");
            Console.Write("\n\nВведите длину массива чисел:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\nВведенные числа:" + "\n");
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + "\t");

            }
            Console.Write("\n\nМассив чисел состоящией из сумы собственных составных индексов относительно оригинального: " + "\n");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = findsumofindexes(a[i]);
                Console.Write(a[i] + "\t");
            }

            int count = 0;
            int rejects = 0;
            
            Console.Write($"\n\n Индексы исходного массива сумма составных индексов числа которых равняется {sum}-ти" + "\n");
            for (int l = 0; l < a.Length; l++)
            {
                if (a[l] == sum)
                {
                    ++count;
                    
                    Console.Write(l + "\t");
                }
                else rejects++;
                Console.WriteLine($"\n\nКоличество совпадний:{count} из {n}-ех общего числа элементов");
                Console.WriteLine($"\n\nКоличество несовпавших:{rejects}из {n}-ех общего числа элементов");
                Console.ReadLine();
            }
        }
    }
}

