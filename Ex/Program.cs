using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)  
        {
            Console.WriteLine("Основнi поняття та термiнологiя 1-16 (20 янв. Изменено: 25 янв.)");
            Console.WriteLine("Select");
            int n = 1;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }


            switch (n)
            {
                case 1:
                    DataType1_1.main();
                    break;
                case 2:
                    DataType1_2.main();
                    break;
                case 3:
                    DataType1_3.main();
                    break;
                case 4:
                    DataType1_4.main();
                    break;
                case 5: 
                    DataType1_5.main();
                    break;
                case 6:
                    DataType1_6.main();
                    break;
                case 7:
                    DataType1_7.main();
                    break;
                case 8:
                    DataType2_1.main();
                    break;
                case 9:
                    DataType2_2.main();
                    break;
                case 10:
                    DataType2_3.main();
                    break;
                case 11:
                    DataType2_4.main();
                    break;
                case 12:
                    DataType2_5.main();
                    break;
                case 13:
                    DataType2_6.main();
                    break;
                case 14:
                    DataType2_7.main();
                    break;
                case 15:
                    DataType2_8.main();
                    break;
                case 16:
                    DataType2_9.main();
                    break;
                default:
                    Console.WriteLine("Out of Range");
                    break;
            }
        }
    }
}
