using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    class DataType1_3
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

            double[] str2 = new double[1];
            try
            {
                str2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int counter = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                for(int j = 0; j< str2.Length; j++)
                {
                    if (str1[i] == str2[j]) counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
