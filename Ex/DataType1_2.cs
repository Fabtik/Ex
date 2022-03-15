using System;
using System.Collections.Generic;
using System.Text;

namespace Ex
{
    class DataType1_2
    {
        public static void main()
        {
            int N = 0;
            Console.Write("N = ");

            HashSet<int> set = new HashSet<int>()
            {
            };

            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            string[] commands = new string[N];

           
           

            for (int i = 0; i < N; i++)
            {
                commands[i] = Console.ReadLine();
            }

            for (int i = 0; i < N; i++)
            {
                if (commands[i].StartsWith("ADD"))
                {
                    try
                    {
                        set.Add(Convert.ToInt32(commands[i].Substring(4)));
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("unknown value" + '\a');
                    }
                }
                else if(commands[i].StartsWith("PRESENT"))
                {
                    if(set.Contains(Convert.ToInt32(commands[i].Substring(7))))
                    {
                        Console.WriteLine("Yes");
                    }
                    else Console.WriteLine("No");
                }
                else if (commands[i].StartsWith("COUNT"))
                {
                        Console.WriteLine(set.Count);
                }
                else Console.WriteLine("unknown command");
            }

            /*foreach (var item in set) // Содержимое
            {
                Console.WriteLine(item);
            }*/
          
        }   
    }
}
        