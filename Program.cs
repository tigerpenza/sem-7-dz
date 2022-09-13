// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.




// double[,] GreateArray2()
// {

//     // Console.WriteLine("введите максимально число массива: ");
//     // int max = Convert.ToInt32(Console.ReadLine());
//     // Console.WriteLine("введите минимальное число массива: ");
//     // int min = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("введите колличество столбцов: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("введите колличество строк ");
//     int m = Convert.ToInt32(Console.ReadLine());

//     double[,] newArray = new double[m, n];

//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             newArray[i, j] = new Random().NextDouble() + new Random().Next(1, 9);
//             newArray[i, j] = Math.Round(newArray[i, j], 3);
//         }
//     }
//     return newArray;
// }

// void ShowArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[,] ArrB = GreateArray2();
// ShowArray(ArrB);





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:


// int[,] Create2dArray()
// {
//     Console.WriteLine("Введите количество строк: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов: ");
//     int n = Convert.ToInt32(Console.ReadLine());


//     int[,] newArray = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newArray[i, j] = i + j;
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// void Poisk(int[,] array, int a, int b)
// {



//     if (a <= array.GetLength(0) && b <= array.GetLength(1))

//         Console.WriteLine("элемент array,[a, b]  существует в заданном массиве ");

//     else
//         Console.WriteLine("элемент array,[a, b] НЕ существует в заданном массиве ");

// }

//     int[,] newArray = Create2dArray();
//     Show2dArray(newArray);

//     Console.WriteLine("Введите первый индекс элемента: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите второй индекс элемента: ");
//     int b = Convert.ToInt32(Console.ReadLine());



//     Poisk(newArray, a, b);









// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreatNewArray()
{
    Console.WriteLine("Enter the number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write(array[i, j] + "  |  ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


void Average(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avr = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            avr = avr + array[i, j];

        avr = (avr / array.GetLength(0));
        avr = Math.Round(avr, 2);
        System.Console.WriteLine($"Arithmetic mean of column number {j + 1} = {avr}");
    }
}

int[,] newArr = CreatNewArray();
ShowArray(newArr);

Average(newArr);