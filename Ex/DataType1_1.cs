using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    class DataType1_1
    {
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

            double[] str = new double[N];
            try
            {
                str = Console.ReadLine().Split().Select(double.Parse).ToArray(); // ввод масива чисел в 1 строку
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }
            

            bool temp;
            int counter = 0;

            for (int i = 0; i < N; i++)
            {
                temp = true; // изначально число уникально
                for(int j = i+1; j<N; j++)
                {
                    if(str[i] == str[j]) // если находиться такое же число
                    {
                        temp = false; // число не уникально
                    }
                }
                if (temp) // если число уникально
                {
                    counter++; // подсчитать
                }
            }

            Console.WriteLine(counter);

        }

    }
}
