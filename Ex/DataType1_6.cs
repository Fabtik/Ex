using System;
using System.Collections.Generic;
using System.Text;

namespace Ex
{
    class DataType1_6
    {
        public static void main()
        {
            double a = 0, b = 0, c = 0;      
            double A, B;
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            A = Math.Round(a + b, 7);
            B = Math.Round(c, 7);

            if (A == B) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
