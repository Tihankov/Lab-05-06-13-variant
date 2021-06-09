using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{

    class Program
    {
        static void Max(object ara)
        {
            int[] arr = (int[])ara;
            int value = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (value < arr[i])
                {
                    value = arr[i];
                }
            }
            Console.WriteLine("Result of first thread:{0} ", value);
        }
        static void Avg(object ara)
        {
            int[] arr = (int[])ara;
            int value = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                value += arr[i];
            }
            value = value / 9;
            Console.WriteLine("Result of second thread:{0} ", value);
        }
        static void Min(object ara)
        {
            int[] arr = (int[])ara;
            int value = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (value > arr[i])
                {
                    value = arr[i];
                }
            }
            Console.WriteLine("Result of third thread:{0} ", value);
        }
        static void Main(string[] args)
        {
            int[] mas = new int[15];
            Random r = new Random();
            
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(-100, 101);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();

            Thread thread1 = new Thread(new ParameterizedThreadStart(Max));
            thread1.Start(mas);
            Thread.Sleep(1000);

            Thread thread2 = new Thread(new ParameterizedThreadStart(Avg));
            thread2.Start(mas);
            Thread.Sleep(1000);

            Thread thread3 = new Thread(new ParameterizedThreadStart(Min));
            thread3.Start(mas);
            Thread.Sleep(1000);

            Console.WriteLine("Done!");
            Console.ReadKey();
        }

    }
}

