using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Ex
{
    class DataType1_4
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

            List<double> set1 = new List<double>(); // Изначально хотел использовать HashSet но как оказалось у него нет сортировки (
            List<double> set2 = new List<double>();

            for (int i = 0; i < str1.Length; i++)
            {
                set1.Add(str1[i]);
            }
            for (int i = 0; i < str2.Length; i++)
            {
                set2.Add(str2[i]);
            }
            set1.Sort();
            set1.Sort();

            IEnumerable<double> both = set1.Intersect(set2);
            foreach (int item in both)
                Console.Write(item + " ");
        }
  
    }
}
