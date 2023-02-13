//Задача №6
//Напишите программу, которая на вход принимает
//число и выдает, является ли число четным

Console.WriteLine("Напишите, число");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 1)
{
    Console.WriteLine("Число" + num + "является : НЕЧЕТНЫМ");
}
else
{
    Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
}