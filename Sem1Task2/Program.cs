//Напишите программу , которая на вход принимает два числа
// и выдает , какое число больше,
//а какое меньше

Console.WriteLine("запишите два числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
 if(numberA > numberB)
 {
    Console.WriteLine($"число A > B");
 }
 else
 {
    Console.WriteLine($"число B > A");
 }