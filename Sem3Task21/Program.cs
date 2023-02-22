// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

 void PrintData(string msg, double val)
 {
    Console.WriteLine(msg+val);
 }

 double CalClen(int x1, int x2, int y1, int y2, int z1, int z2)
 {
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
 }
 int x1 = ReadData("Введите координату х точки А: ");
 int x2 = ReadData("Введите координату х точки А: ");
 int y1 = ReadData("Введите координату y точки В: ");
 int y2 = ReadData("Введите координату y точки В: ");
 int z1 = ReadData("Введите координату y точки C: ");
 int z2 = ReadData("Введите координату y точки C: ");

 double res = CalClen(x1, x2, y1, y2, z1, z2);

 PrintData("Расстояние между точками А и В и C: ", res);