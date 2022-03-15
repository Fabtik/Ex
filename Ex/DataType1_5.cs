using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    class DataType1_5
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

            bool temp;
            for(int i = 0; i < str1.Length; i++)
            {
                temp = false;
                for(int j = i-1; j > -1; j--)
                {
                    if( str1[i] == str1[j])
                    {
                        temp = true;
                    }
                }
                if (temp) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}
