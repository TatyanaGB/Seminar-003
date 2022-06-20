//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < n)
{
int result = Cube(count);
count = count + 1;
Console.Write($"{result}, ");
}
Console.WriteLine(Cube(n));

int Cube (int a)
{
return a * a * a;
}

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*int x1 = Input("Введите координату X1: ");
int y1 = Input("Введите координату Y1: ");
int z1 = Input("Введите координату Z1: ");
int x2 = Input("Введите координату X2: ");
int y2 = Input("Введите координату Y2: ");
int z2 = Input("Введите координату Z2: ");

int distanceX = CalculateDistance(x1, x2);
int distanceY = CalculateDistance(y1, y2);
int distanceZ = CalculateDistance(z1, z2);

double distance = Math.Sqrt(Quadro(distanceX) + Quadro(distanceY) + Quadro(distanceZ));

Console.WriteLine("Расстояние между точками " + distance);

int Quadro(int a)
{
return a * a;
}

int CalculateDistance(int a, int b)
{
return a - b;
}

int Input(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}*/

//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
    
int E = number % 10;
int D = number / 10;
int C = number / 10;
int B = number / 10;
int A = number / 1;

if (Compare (E, D, C, B, A) == (A, B, C, D, E))
{
    Console.WriteLine(number + "палиндром");
}

else
{
    Console.WriteLine(number + "не палиндром");
    bool Compare (int A, int B, int C, int D, int E);
}*/


