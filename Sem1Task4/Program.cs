//Задача №4
//Напишите программу, которая принимает на вход
//три числа ивыдает максимальное из этих чисел

Console.WriteLine("Запишите три числа");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());
int Max = numA;

if (numA > Max)
{
    Max = numA;
}

if (numB > Max)
{
    Max = numB;
}

if (numC > Max);
{
    Max = numC;
}
Console.WriteLine("Наибольшее из выведенных чисел ->" + Max);