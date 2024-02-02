using System;
namespace fpgiuh
{
    public class JaggedDimensional
    {
        private int rows;
        private int[][] array;

        public JaggedDimensional(int rows, bool choice = false)
        {
            array = new int[rows][];
            if (!choice)
            {
                array = fillJaggedArray_Random(rows);
            }
            else
            {
                array = GetJaggedArrayInput(rows);
            }
            PrintArrayJagged(array);
        }

        private int[][] fillJaggedArray_Random(int rows)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int columns = rand.Next(1, 6);
                array[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    array[i][j] = rand.Next(-200, 200);
                }
                Console.WriteLine();
            }
            return array;
        }

        private int[][] GetJaggedArrayInput(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"элементов в {i + 1} подмассиве: ");
                array[i] = new int[int.Parse(Console.ReadLine())];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return array;
        }

        public void MiddleValueJagged()
        {
            Console.WriteLine("\nЗадание 1");
            int sum = 0;
            int counter = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    counter += 1;
                }
            }
            try
            {
                Console.WriteLine(sum / (counter - 1));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Пустой массив: {e.Message}");
                throw;
            }
        }

        public void MiddleValueInEachJagged()
        {
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            for (int i = 0; i < array.Length; i++)
            {
                int summa = 0;
                int counter = 1;
                for (int j = 0; j < array[i].Length; j++)
                {
                    summa += array[i][j];
                    counter += 1;
                }
                try
                {
                    Console.WriteLine(summa / (counter - 1));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Пустой массив: {e.Message}");
                    throw;
                }
            }
        }

        public void JaggedArray_ReplaceEvenValues()
        {
            Console.WriteLine();
            Console.WriteLine("Задание 3");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
            PrintArrayJagged(array);
        }

        private static void PrintArrayJagged(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
