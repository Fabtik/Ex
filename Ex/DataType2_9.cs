using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex
{
    class DataType2_9
    {
        struct Student
        {
            public string Name;
            public string SName;
            public double mat;
            public double fiz;
            public double inf;
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
            Console.WriteLine("Before Sort");
            for (int i = 0; i < N; i++)
            {
                PrintStudent(ArrStudent[i]);
            }

            //Bublesort
            string tempName, tempSName;
            double tempMat = 0, tempFiz = 0, tempInf = 0;
            for (int write = 0; write < ArrStudent.Length; write++)
            {
                for (int sort = 0; sort < ArrStudent.Length - 1; sort++)
                {
                    if ((ArrStudent[sort].mat + ArrStudent[sort].fiz + ArrStudent[sort].inf) / 3 < (ArrStudent[sort + 1].mat + ArrStudent[sort + 1].fiz + ArrStudent[sort + 1].inf) / 3)
                    {
                        tempName = ArrStudent[sort + 1].Name;
                        tempSName = ArrStudent[sort + 1].SName;
                        tempMat = ArrStudent[sort + 1].mat;
                        tempFiz  = ArrStudent[sort + 1].fiz;
                        tempInf = ArrStudent[sort + 1].inf;
                        ArrStudent[sort + 1] = ArrStudent[sort];
                        ArrStudent[sort].Name = tempName;
                        ArrStudent[sort].SName = tempSName;
                        ArrStudent[sort].mat = tempMat;
                        ArrStudent[sort].fiz = tempFiz;
                        ArrStudent[sort].inf = tempInf;
                    }
                }
            }

            Console.WriteLine("After Sort");
            for (int i = 0; i < N; i++)
            {
                PrintStudent(ArrStudent[i]);
            }

        }



        static void PrintStudent(Student st)
        {
            Console.WriteLine("Name: " + st.Name + " " + st.SName + " Maths: " + st.mat + " Physics: " + st.fiz + " Informatics: " + st.inf);
        }

        
    }
}
