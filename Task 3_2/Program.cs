using System;

namespace fpgiuh;

class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Массив будет вручную(0) или автоматически(1)? ");
        bool choice = Choice_Main_or_Auto();

        Console.WriteLine("One-Dimensional");
        Console.WriteLine("Ввидите длину массива: ");
        int length = int.Parse(Console.ReadLine());
        OneDimensional array_onedimensional = new OneDimensional(length, choice);
        Console.WriteLine("\nХотите ли вы пересоздать массив да(1)/нет(0)?");
        bool choice1 = Choice_Main_or_Auto();
        array_onedimensional.Create(choice1);
        array_onedimensional.PrintArray();
        array_onedimensional.Average_Value();
        array_onedimensional.over_one_hundred();
        array_onedimensional.without_repeats();

        Console.WriteLine();
        Console.WriteLine("Two-Dimensional");
        (int, int) twoInput = Input();
        TwoDimensional array_twodimensional = new TwoDimensional(twoInput.Item1, twoInput.Item2);
        Console.WriteLine("\nХотите ли вы пересоздать массив да(1)/нет(0)?");
        bool choice2 = Choice_Main_or_Auto();
        array_twodimensional.Create(choice2);
        array_twodimensional.Average_Value();
        array_twodimensional.PrintArray();
        array_twodimensional.PrintEventLines();

        Console.WriteLine("\nJagged array");
        JaggedDimensional array_jagdimensional = new JaggedDimensional(InputJaggedDimensional());
        Console.WriteLine("\nХотите ли вы пересоздать массив да(1)/нет(0)?");
        bool choice3 = Choice_Main_or_Auto();
        array_jagdimensional.Average_Value();
        array_jagdimensional.MiddleValueInEachJagged();
        array_jagdimensional.JaggedArray_ReplaceEvenValues();

    }

    static bool Choice_Main_or_Auto()
    {
        int a = int.Parse(Console.ReadLine());
        bool choice = true;
        if(a == 0)
        {
            choice = false;
        }
        else if(a == 1)
        {
            choice = true;
        }
        return choice;
    }

    static (int, int) Input()
    {
        Console.WriteLine("Введите число строчек в массиве: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число колоннок в массиве: ");
        int columns = int.Parse(Console.ReadLine());
        return(rows, columns);
    }

    static int InputJaggedDimensional()
    {
        Console.WriteLine("Введите число строчек в массиве: ");
        int rows = int.Parse(Console.ReadLine());
        return rows;
    }
}


