using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    class DataType2_4
    {
        struct Point
        {
            public double PointX;
            public double PointY;
            public double Distance;
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

            double[] str = new double[2];
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

                try
                {
                    ArrPoint[i].PointX = str[0];
                    ArrPoint[i].PointY = str[1];
                    ArrPoint[i].Distance = GetDistanceO(ArrPoint[i]);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("error FormatException" + '\a');
                    Environment.Exit(0);//прервать выполнение
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("IndexOutOfRangeException" + '\a');
                    Environment.Exit(0);//прервать выполнение
                }
            }

            Console.WriteLine("Before Sort");
            for (int i = 0; i < ArrPoint.Length; i++)
            {
                Console.WriteLine("Point " + (i+1) + " (" + ArrPoint[i].PointX + ", " + ArrPoint[i].PointY + ") " + " Distance = " + ArrPoint[i].Distance);
            }

            //Bublesort
            double temp = 0, tempX = 0, tempY = 0;
            for (int write = 0; write < ArrPoint.Length; write++)
            {
                for (int sort = 0; sort < ArrPoint.Length - 1; sort++)
                {
                    if (ArrPoint[sort].Distance > ArrPoint[sort + 1].Distance)
                    {
                        temp = ArrPoint[sort + 1].Distance;
                        tempX = ArrPoint[sort + 1].PointX;
                        tempY = ArrPoint[sort + 1].PointY;
                        ArrPoint[sort + 1] = ArrPoint[sort];
                        ArrPoint[sort].Distance = temp;
                        ArrPoint[sort].PointX = tempX;
                        ArrPoint[sort].PointY = tempY;
                    }
                }
            }

            Console.WriteLine("After Sort");
            for (int i = 0; i < ArrPoint.Length; i++)
            {
                Console.WriteLine("Point " + (i + 1) + " (" + ArrPoint[i].PointX + ", " + ArrPoint[i].PointY + ") " + " Distance = " + ArrPoint[i].Distance);
            }
        }

        // Растояние от точки до начала координат О(0, 0)
        static double GetDistanceO(Point point)
        {
            return Math.Sqrt(point.PointX * point.PointX + point.PointY * point.PointY);
        }

    }
}
