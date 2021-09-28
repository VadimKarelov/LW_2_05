using System;

namespace LW_2_05
{
    class Program
    {
        static private int[] array;
        static private int[,] matrix;
        static private int[][] jaggedArray;

        static private Random rn = new Random();

        static void Main(string[] args)
        {
            MainMenu();
        }

        static private void MainMenu()
        {
            string vvod = "";
            do
            {
                Console.WriteLine(@"
Главное меню:
0 - выход
1 - работа с одномерным массивом
2 - работа с двумерным массивом
3 - работа с рваным массивом");

                vvod = Console.ReadLine();
                switch (vvod)
                {
                    case "0": break;
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
                Console.WriteLine(@"
Одномерный массив:
0 - назад
1 - печать одномерного массива
2 - создание одномерного массива
3 - удаление элементов");

                vvod = Console.ReadLine();
                switch (vvod)
                {
                    case "0": break;
                    case "1": Print(array); break;
                    case "2": CreateArray(); break;
                    default: Console.WriteLine("Ошибка ввода"); break;
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
                    res += array[i] + " ";
                }
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Массив пуст");
            }
        }

        static private void CreateArray()
        {
            string vvod = "";
            do
            {
                Console.WriteLine(@"
Создание одномерного массив:
0 - назад
1 - ручной ввод
2 - автоматическое заполнение");

                vvod = Console.ReadLine();
                switch (vvod)
                {
                    case "0": break;
                    case "1": array = ManualArrayCreation(); break;
                    case "2": array = AutoArrayCreation(); break;
                    default: Console.WriteLine("Ошибка ввода"); break;
                }
            } while (vvod != "0");
        }

        static private int[] ManualArrayCreation()
        {
            int n = -1;
            do
            {
                Console.WriteLine("Введите размер массива");
            } while (!int.TryParse(Console.ReadLine(), out n) && n < 1);

            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine($"Введите {i + 1} элемент массива");
                } while (!int.TryParse(Console.ReadLine(), out res[i]));
            }
            Console.WriteLine("Массив создан");
            return res;
        }

        static private int[] AutoArrayCreation()
        {
            int n = -1;
            do
            {
                Console.WriteLine("Введите размер массива");
            } while (!int.TryParse(Console.ReadLine(), out n) && n < 1);

            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = rn.Next(-100, 100);
            }
            Console.WriteLine("Массив создан");
            return res;
        }

        // ==== matrix ====
        static private void MatrixMenu()
        {
            string vvod = "";
            do
            {
                Console.WriteLine(@"
Двумерный массив:
0 - назад
1 - печать двумерного массива
2 - создание двумерного массива
3 - добавление столбца в начало");

                vvod = Console.ReadLine();
                switch (vvod)
                {
                    case "0": break;
                    case "1": Print(matrix); break;
                    default: Console.WriteLine("Ошибка ввода"); break;
                }
            } while (vvod != "0");
        }

        static private void Print(int[,] matrix)
        {
            if (matrix != null && matrix.Length > 0)
            {
                string res = "";
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; i < matrix.GetLength(1); i++)
                    {
                        res += matrix[i, j].ToString() + " ";
                    }
                    res += "\n";
                }
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Массив пуст");
            }
        }

        // ==== jagged array ====
        static private void JaggedArrayMenu()
        {
            string vvod = "";
            do
            {
                Console.WriteLine(@"
Рваный массив:
0 - назад
1 - печать рваного массива
2 - создание рваного массива
3 - удаление строк");

                vvod = Console.ReadLine();
                switch (vvod)
                {
                    case "0": break;
                    case "1": Print(jaggedArray); break;
                    default: Console.WriteLine("Ошибка ввода"); break;
                }
            } while (vvod != "0");
        }

        static private void Print(int[][] jaggedArray)
        {
            if (jaggedArray != null && jaggedArray.Length > 0)
            {
                string res = "";
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        res += jaggedArray[i][j].ToString() + " ";
                    }
                    res += "\n";
                }
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Массив пуст");
            }
        }
    }
}
