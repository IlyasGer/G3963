// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int ReadData(string mgs)
{
    Console.WriteLine(mgs);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string LineBuilder(int end, int pow)
{
    string res = String.Empty;

    for(int i = 1; i<=end; i++)
    {
        res = res + Math.Pow(i, pow+1)+ "\t";
    }
    return res;
}

int N = ReadData("Введите конечное число: ");
Console.WriteLine(LineBuilder(N,0));
Console.WriteLine(LineBuilder(N,2));