using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    struct Student
    {
        public string Name;
        public string SName;
        public double mat;
        public double fiz;
        public double inf;
    };
    class DataType2_7
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

            Student[] ArrStudent = new Student[N];

            string[] str = new string[2];
            for (int i = 0; i < N; i++)
            {
                try
                {
                    str = Console.ReadLine().Split().ToArray();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("error FormatException" + '\a');
                    Environment.Exit(0);//прервать выполнение
                }

                try
                {
                    ArrStudent[i].Name = str[0];
                    ArrStudent[i].SName = str[1];
                    ArrStudent[i].mat = Convert.ToDouble(str[2]);
                    ArrStudent[i].fiz = Convert.ToDouble(str[3]);
                    ArrStudent[i].inf = Convert.ToDouble(str[4]);
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
                if (ArrStudent[i].mat > 5) ArrStudent[i].mat = 5;
                if (ArrStudent[i].mat < 1) ArrStudent[i].mat = 1;
                if (ArrStudent[i].fiz > 5) ArrStudent[i].fiz = 5;
                if (ArrStudent[i].fiz < 1) ArrStudent[i].fiz = 1;
                if (ArrStudent[i].inf > 5) ArrStudent[i].inf = 5;
                if (ArrStudent[i].inf < 1) ArrStudent[i].inf = 1;
            }
            for (int i = 0; i < N; i++)
            {
                PrintStudent(ArrStudent[i]);
            }
            Console.WriteLine(Ser(ArrStudent));
        }
        static void PrintStudent(Student st)
        {
            Console.WriteLine("Name: " + st.Name + ' ' + st.SName + " Maths: " + st.mat + " Physics: " + st.fiz + " Informatics: " + st.inf);
        }

        static (double, double, double) Ser(Student[] st)
        {
            double serMat = 0, serFiz = 0, serInf = 0;
            for(int i = 0; i < st.Length; i++)
            {
                serMat += st[i].mat;
                serFiz += st[i].fiz;
                serInf += st[i].inf;
            }
            return (serMat/st.Length, serFiz/st.Length, serInf/st.Length);
        }

    }
}
