//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*Console.WriteLine("Введите число A :  ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B :  ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Pow(int numberA, int numberB);
{
	int res = numberA;
    Console.WriteLine (res)
	for (int i = 1; i < numberB; i++)
	{
		res *= numberA;
	}
	return res;
}*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*Console.WriteLine("Введите число N :  ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1000 && number < 10000);
{
    int last number = number % 10;
    int third number = number / 10;
    int second number = number / 10;
    int first number = number / 1;
    int sum = sum("first number,second number, third number, last number");
    Console.WriteLine(sum);
} 

if (number > 100 && number < 1000);
{
    int last number = number % 10;
    int second number = number / 10;
    int first number = number / 1;
    int sum = sum("first number, second number, last number");
    Console.WriteLine(sum);
}

if (number > 10 && number < 100);
{
    int last number = number % 10;
    int first number = number / 1;
    int sum = sum("first number, last number");
    Console.WriteLine(sum);

}
int sum (int a, int b, int c, int d);

{
return a + b + c + d;
}*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
int i;
int[] a = new int[8];
Console.WriteLine("Введите массив чисел:  ");
for (i = 0; i < 8; i++)
{
a[i] = int Parse(Console.ReadLine());
}
 
for (i = 0; i < 8; i++)
{
Console.Write(a[i]);
}