using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    class DataType1_7
    {
        public static void main()
        {
            double[] str1 = new double[1];
           
                try
                {
                    str1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("error FormatException" + '\a');
                    Environment.Exit(0);//прервать выполнение
                }

            double X = 0, Y = 0, Z = 0;

                try
                {
                    X = str1[0];
                    Y = str1[1];
                    Z = str1[2];
                }
                catch (System.IndexOutOfRangeException)
                {
                    //Console.WriteLine("IndexOutOfRangeException");
                }

            int N = 0;
            Console.Write("N = ");

                try
                {
                    N = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("error FormatException" + '\a');
                    Environment.Exit(0);//прервать выполнение
                }

            double[] str2 = new double[1];


            double countX = 0, countY = 0, countZ = 0;

            for (int i = 0; i < N; i++)
            {
                try
                {
                    str2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("error FormatException" + '\a');
                    Environment.Exit(0);//прервать выполнение
                }
               
                countX += Math.Round((str2[0] * str2[3]), 5);
                countY += Math.Round((str2[1] * str2[3]), 5);
                countZ += Math.Round((str2[2] * str2[3]), 5);
            }

            if (countX >= X && countY >= Y && countZ >= Z)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");

        }
    }
}
