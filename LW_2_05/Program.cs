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
            string vvod;
            do
            {
                Console.Clear();
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
                    default: Console.WriteLine("Ошибка ввода. Нажмите любую клавишу."); Console.ReadKey(); break;
                }
            } while (vvod != "0");
        }

        // ==== array ====
        static private void ArrayMenu()
        {
            string vvod;
            do
            {
                Console.Clear();
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
                    case "3": array = DeleteElementsFromArray(array); break;
                    default: Console.WriteLine("Ошибка ввода. Нажмите любую клавишу."); Console.ReadKey(); break;
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
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }

        static private void CreateArray()
        {
            string vvod;
            do
            {
                Console.Clear();
                Console.WriteLine(@"
Создание одномерного массива:
0 - назад
1 - ручной ввод
2 - автоматическое заполнение");

                vvod = Console.ReadLine();
                switch (vvod)
                {
                    case "0": break;
                    case "1": array = ManualArrayCreation(); break;
                    case "2": array = AutoArrayCreation(); break;
                    default: Console.WriteLine("Ошибка ввода. Нажмите любую клавишу."); Console.ReadKey(); break;
                }
            } while (vvod != "0");
        }

        static private int[] ManualArrayCreation()
        {
            int n = -1;
            do
            {
                Console.WriteLine("Введите размер массива");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);

            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine($"Введите {i + 1} элемент массива");
                } while (!int.TryParse(Console.ReadLine(), out res[i]));
            }
            Console.WriteLine("Массив создан. Нажмите любую клавишу.");
            Console.ReadKey();
            return res;
        }

        static private int[] AutoArrayCreation()
        {
            int n = -1;
            do
            {
                Console.WriteLine("Введите размер массива");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);

            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = rn.Next(-100, 100);
            }
            Console.WriteLine("Массив создан. Нажмите любую клавишу.");
            Console.ReadKey();
            return res;
        }

        static private int[] DeleteElementsFromArray(int[] array)
        {
            int[] res;
            if (array != null && array.Length > 0)
            {
                int k, n;
                do
                {
                    Console.WriteLine($"Введите номер элемента, с которого начинать удаление (1-{array.Length})");
                } while (!int.TryParse(Console.ReadLine(), out k) || (k < 1 || k > array.Length));
                do
                {
                    Console.WriteLine($"Введите количество элементов для удаления (0-{array.Length - k + 1})");
                } while (!int.TryParse(Console.ReadLine(), out n) || (n < 0 || n > array.Length - k + 1));
                res = new int[array.Length - n];                
                k--; // get index from number
                // copy first part
                for (int i = 0; i < k; i++)
                {
                    res[i] = array[i];
                }
                // copy second part
                for (int i = k + n; i < k + n; i++)
                {
                    res[i] = array[i - n];
                }
                Console.WriteLine("Удаление завершено. Нажмите любую клавишу.");
            }
            else
            {
                Console.WriteLine("Ошибка. Массив пуст. Удаление не удалось. Нажмите любую клавишу.");
                res = new int[0];
            }
            Console.ReadKey();
            return res;
        }

        // ==== matrix ====
        static private void MatrixMenu()
        {
            string vvod;
            do
            {
                Console.Clear();
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
                    case "2": CreateMatrix(); break;
                    case "3": matrix = AddColumnToMatrix(matrix); break;
                    default: Console.WriteLine("Ошибка ввода. Нажмите любую клавишу."); Console.ReadKey(); break;
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
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        res += matrix[i, j].ToString() + "\t";
                    }
                    res += "\n";
                }
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Массив пуст");
            }
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }

        static private void CreateMatrix()
        {
            string vvod;
            do
            {
                Console.Clear();
                Console.WriteLine(@"
Создание двумерного массива:
0 - назад
1 - ручной ввод
2 - автоматическое заполнение");

                vvod = Console.ReadLine();
                switch (vvod)
                {
                    case "0": break;
                    case "1": matrix = ManualMatrixCreation(); break;
                    case "2": matrix = AutoMatrixCreation(); break;
                    default: Console.WriteLine("Ошибка ввода. Нажмите любую клавишу."); Console.ReadKey(); break;
                }
            } while (vvod != "0");
        }

        static private int[,] ManualMatrixCreation()
        {
            int n = -1, m = -1;
            do
            {
                Console.WriteLine("Введите колво строк");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);
            do
            {
                Console.WriteLine("Введите колво столбцов");
            } while (!int.TryParse(Console.ReadLine(), out m) || m < 1);

            int[,] res = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    do
                    {
                        Console.WriteLine($"Введите {i + 1}:{j + 1} элемент массива");
                    } while (!int.TryParse(Console.ReadLine(), out res[i, j]));
                }
            }
            Console.WriteLine("Массив создан. Нажмите любую клавишу.");
            Console.ReadKey();
            return res;
        }

        static private int[,] AutoMatrixCreation()
        {
            int n = -1, m = -1;
            do
            {
                Console.WriteLine("Введите колво строк");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);
            do
            {
                Console.WriteLine("Введите колво столбцов");
            } while (!int.TryParse(Console.ReadLine(), out m) || m < 1);

            int[,] res = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    res[i, j] = rn.Next(-100, 100);
                }
            }
            Console.WriteLine("Массив создан. Нажмите любую клавишу.");
            Console.ReadKey();
            return res;
        }

        static private int[,] AddColumnToMatrix(int[,] matrix)
        {
            int[,] res;
            if (matrix != null && matrix.Length > 0)
            {
                res = new int[matrix.GetLength(0), matrix.GetLength(1) + 1];
                // insert column
                for (int i = 0; i < matrix.GetLength(0); i++)
                {                    
                    do
                    {
                        Console.WriteLine($"Введите элемент ({i + 1}:{1})");
                    } while (!int.TryParse(Console.ReadLine(), out res[i, 0]));
                }
                // copy second part
                for (int i = 1; i < res.GetLength(1); i++)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        res[j, i] = matrix[j, i - 1];
                    }
                }
                Console.WriteLine("Столбец добавлен. Нажмите любую клавишу.");
            }
            else
            {
                Console.WriteLine("Ошибка. Массив пуст. Удаление не удалось. Нажмите любую клавишу.");
                res = new int[0, 0];
            }
            Console.ReadKey();
            return res;
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
