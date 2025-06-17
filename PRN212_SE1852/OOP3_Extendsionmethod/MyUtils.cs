using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_Extendsionmethod
{
    static class MyUtils
    {
        // setting function sum of 1 to N for int type of Micosoft
        public static int Sum(this int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static void Sortincrease(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tempp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tempp;
                    }

                }
            }
        }

        public static void Random(this int[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = r.Next(100);
            }
        }

        public static void Array(this int[] arr)
        {
            for(int i = 0;i < arr.Length; ++i)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
