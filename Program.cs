using System;

namespace fpgiuh;

class MainClass
{
    public static void Main()
    {
        bool choice = Choice_Main_or_Auto();

        Console.WriteLine("One-Dimensional");
        Console.WriteLine("Ввидите длину массива: ");
        int length = int.Parse(Console.ReadLine());
        OneDimensional array_onedimensional = new OneDimensional(length, choice);
        array_onedimensional.PrintArray_One();
        array_onedimensional.Average_Value_one();
        array_onedimensional.over_one_hundred();
        array_onedimensional.without_repeats();

        Console.WriteLine();
        Console.WriteLine("Two-Dimensional");
        (int, int) twoInput = Input();
        TwoDimensional array_twodimensional = new TwoDimensional(twoInput.Item1, twoInput.Item2);
        array_twodimensional.Average_Value_two();
        array_twodimensional.matrixValue_two();

        Console.WriteLine();
        Console.WriteLine("Jagged array");
        JaggedDimensional array_jagdimensional = new JaggedDimensional(InputJaggedDimensional());
        array_jagdimensional.MiddleValueJagged();
        array_jagdimensional.MiddleValueInEachJagged();
        array_jagdimensional.JaggedArray_ReplaceEvenValues();

    }

    static bool Choice_Main_or_Auto()
    {
        Console.WriteLine("Массив будет вручную(0) или автоматически(1)? ");
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


