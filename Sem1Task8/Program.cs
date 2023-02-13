// Задача №8
//Напишите программу, которая на вход принимает число N,
// а на выходе показывает все четные числа от 1 до N.

 int i = 1;


Console.WriteLine("Введите число:");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + numN);
while (i <= numN)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    
    }
    i++;
}
Console.WriteLine("Нет чётных чисел!");
