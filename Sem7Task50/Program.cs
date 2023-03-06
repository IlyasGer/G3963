// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


 Console.Clear();


int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// Заполнение массива рандомными числами от 1 до 9
void FillArray2D(int[,] array)
{
    //ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.DarkRed};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            //Console.ForegroundColor=col[new Random().Next(0,3)];
            array[i, j] = new Random().Next(1, 10);
            //Console.ResetColor();
        }
    }
}

//  Функция вывода массива в терминал
void PrintArray2D(int[,] array)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.DarkRed};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Console.ForegroundColor=col[new Random().Next(0,3)];
            Console.Write(array[i, j] + " ");
            //Console.ResetColor();
        }
        Console.WriteLine();
    }
    
}

// Функция ввода 
int ReadInt(string message)
{    
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


