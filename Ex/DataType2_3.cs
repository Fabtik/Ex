using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    class DataType2_3
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
            Console.WriteLine(Convert.ToString(GetDiam(ArrPoint)));
        }


        static double GetDiam(Point[] point)
        {
            double Diam = 0;

            for (int i = 0; i < point.Length; i++)
            {
                for (int j = 0; j < point.Length; j++)
                {
                    if (Diam < Math.Sqrt(Math.Pow(point[j].PointX - point[i].PointX, 2) + Math.Pow(point[j].PointY - point[i].PointY, 2)))
                    {
                        Diam = Math.Sqrt(Math.Pow(point[j].PointX - point[i].PointX, 2) + Math.Pow(point[j].PointY - point[i].PointY, 2));
                    }
                }
            }

            return Math.Round(Diam, 15);
        }
    }
}
