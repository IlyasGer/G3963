// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();



// Функция (Метод) ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


// Функция (Метод) для заполнения 2D массива вещественными (double) числами
double[,] Gen2DArray(int row, int column)
{
    
    int i = 0; int j = 0;
    double[,] arr = new double[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = Math.Round(new Random().Next(0, 101) + new Random().NextDouble(), 4);
            j++;
        }
        i++;
    }
    return arr;
}

// Функция (Метод) вывода 2D  массива в консоль
void Print2DArr(double[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                         ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                                         ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                         ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                                         ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White,
                                         ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            Console.Write(arr[i, j]  + "  \t  ");            
            Console.ResetColor();
        }
        Console.WriteLine("");
    }
    // Console.WriteLine("Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));");
}

//  Получение данных от пользователя
int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");

//  Генерируем 2D  массив
double[,] arr2D = Gen2DArray(n, m);

//  Печатаем двумерный массив
Print2DArr(arr2D);
Console.WriteLine("");