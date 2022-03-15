using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    class DataType2_2
    {
        struct Point
        {
            public double PointX;
            public double PointY;
        };

        public static void main()
        {
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

            Point[] ArrPoint = new Point[N];

            double[] str = new double[1];

            for (int i = 0; i < N; i++)
            {
                try
                {
                    str = Console.ReadLine().Split().Select(double.Parse).ToArray();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("error FormatException" + '\a');
                    Environment.Exit(0);//прервать выполнение
                }
                ArrPoint[i].PointX = str[0];
                ArrPoint[i].PointY = str[1];
            }

            Console.WriteLine(average(ArrPoint));

        }

        static (double, double) average(Point[] point)
        {
            double sumX = 0;
            double sumY = 0;
            for (int i = 0; i < point.Length; i++)
            {
                sumX += point[i].PointX;
                sumY += point[i].PointY;
            }

            return (sumX / point.Length, sumY / point.Length);
        }
    }
}
