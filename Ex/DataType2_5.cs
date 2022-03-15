using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    class DataType2_5
    {
        struct Point
        {
            public double PointX;
            public double PointY;
        }

        struct Triangle
        {
            public Point a;
            public Point b;
            public Point c;
        }

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
            PrintTriangle(MakeTriangleFromPoints(ArrPoint));
            Console.Write("MaxP = ");
            MaxP(MakeTriangleFromPoints(ArrPoint));
        }

        static double P(Triangle triangle)
        {
            double P = 0;
            P += Math.Sqrt(Math.Pow(triangle.a.PointX - triangle.b.PointX, 2) + Math.Pow(triangle.a.PointY - triangle.b.PointY, 2));
            P += Math.Sqrt(Math.Pow(triangle.b.PointX - triangle.c.PointX, 2) + Math.Pow(triangle.b.PointY - triangle.c.PointY, 2));
            P += Math.Sqrt(Math.Pow(triangle.c.PointX - triangle.a.PointX, 2) + Math.Pow(triangle.c.PointY - triangle.a.PointY, 2));
            return P;
        }

        static void MaxP(Triangle[] triangle)
        {
            double Max = 0;
            for (int i = 0; i < triangle.Length; i++)
            {
                if (Max < P(triangle[i]))
                {
                    Max = P(triangle[i]);
                }
            }

            Console.WriteLine(Max);
        }

        static Triangle[] MakeTriangleFromPoints(Point[] points)
        {
            Triangle[] res = new Triangle[(fact(points.Length) / (3! * fact(points.Length - 3))) / 2];
            int b = 0;
            for (int i = 0; i < points.Length - 2; i++)
            {
                for (int j = i + 1; j < points.Length - 1; j++)
                {
                    for (int k = j + 1; k < points.Length; k++)
                    {
                        res[b].a = points[i];
                        res[b].b = points[j];
                        res[b].c = points[k];
                        b++;
                    }
                }

            }
            return res;
        }

        static void PrintPoint(Point point)
        {
            Console.Write("( " + point.PointX + " ; " + point.PointY + " )");
        }

        static void PrintTriangle(Triangle[] triangle)
        {
            for (int i = 0; i < triangle.Length; i++)
            {
                Console.Write("[ ");
                PrintPoint(triangle[i].a);
                Console.Write(" ");
                PrintPoint(triangle[i].b);
                Console.Write(" ");
                PrintPoint(triangle[i].c);
                Console.Write(" ]   P = ");
                Console.WriteLine(P(triangle[i]));
            }
        }

        static int fact(int n)
        {
            int res = 1;
            for (int i = n; i > 1; i--)
            {
                res *= i;
            }
            return res;
        }

    }
}
