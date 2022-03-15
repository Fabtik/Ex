using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    class DataType2_1
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

            Console.WriteLine(ArrPoint[Max(ArrPoint)].PointX + " " + ArrPoint[Max(ArrPoint)].PointY);

        }

        // Растояние от точки до начала координат О(0, 0)
        static double GetDistanceO(Point point)
        {

            return Math.Sqrt(point.PointX * point.PointX + point.PointY * point.PointY);
        }

        // Точка с максимальним растоянием от начала координат
        static int Max(Point[] arr)
        {
            double max = GetDistanceO(arr[0]);
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < GetDistanceO(arr[i]))
                {
                    max = GetDistanceO(arr[i]);
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

    }
}
