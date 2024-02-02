using System;
namespace fpgiuh
{
    public sealed class JaggedDimensional : BaseArray
    {
        private int rows;
        private int[][] array;
        private static bool choice3;

        public JaggedDimensional(int rows, bool choice = false) : base(choice3)
        {
            array = new int[rows][];
            if (!choice)
            {
                fill_RandomArray();
            }
            else
            {
                fillArray_by_User();
            }
            PrintArray();
        }

        public override void Create(bool choice3)
        {
            if (!choice3)
            {
                fill_RandomArray();
            }
            else
            {
                fillArray_by_User();
            }
        }

        protected override void fill_RandomArray()
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int columns = rand.Next(1, 6);
                array[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    array[i][j] = rand.Next(-150, 150);
                }
                Console.WriteLine();
            }
        }

        protected override void fillArray_by_User()
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
        }

        public override decimal Average_Value()
        {
            Console.WriteLine("\nЗадание 1");
            int summa = 0;
            int counter = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    summa += array[i][j];
                    counter += 1;
                }
            }
            return summa / counter;
        }

        public void MiddleValueInEachJagged()
        {
            Console.WriteLine("\nЗадание 2");
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
            PrintArray();
        }

        public override void PrintArray()
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
