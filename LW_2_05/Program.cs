using System;

namespace LW_2_05
{
    class Program
    {
        static private int[] array;
        static private int[,] matrix;
        static private int[][] jaggedArray;

        static void Main(string[] args)
        {
            MainMenu();
        }

        static private void MainMenu()
        {
            string vvod = "";
            do
            {
                Console.WriteLine(@"0 - выход
1 - работа с одномерным массивом
2 - работа с двумерным массивом
3 - работа с рваным массивом");

                vvod = Console.ReadLine();
                switch (vvod)
                {
                    case "1": ArrayMenu(); break;
                    case "2": MatrixMenu(); break;
                    case "3": JaggedArrayMenu(); break;
                    default: Console.WriteLine("Ошибка ввода"); break;
                }
            } while (vvod != "0");
        }

        // ==== array ====
        static private void ArrayMenu()
        {
            string vvod = "";
            do
            {
                Console.WriteLine(@"0 - назад
1 - печать одномерного массива
2 - создание одномерного массива
3 - удаление элементов");

                vvod = Console.ReadLine();
                switch (vvod)
                {
                    case "1": Print(array); break;
                }
            } while (vvod != "0");
        }

        static private void Print(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                string res = "";
                for (int i = 0; i < array.Length; i++)
                {
                    res += array[0] + " ";
                }
            }
            else
            {
                Console.WriteLine("Массив пуст");
            }
        }

        // ==== matrix ====
        static private void MatrixMenu()
        {
            string vvod = "";
            do
            {
                Console.WriteLine(@"0 - назад
1 - печать двумерного массива
2 - создание двумерного массива
3 - добавление столбца в начало");

                vvod = Console.ReadLine();
                switch (vvod)
                {

                }
            } while (vvod != "0");
        }

        // ==== jagged array ====
        static private void JaggedArrayMenu()
        {
            string vvod = "";
            do
            {
                Console.WriteLine(@"0 - назад
1 - печать рваного массива
2 - создание рваного массива
3 - удаление строк");

                vvod = Console.ReadLine();
                switch (vvod)
                {

                }
            } while (vvod != "0");
        }
    }
}
