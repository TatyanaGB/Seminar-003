// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdNumber = number % 10;
int secondNumber = number / 10;
Console.WriteLine(secondNumber);*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10000 && number < 100000)
{
    int fithNumber =  number % 10;
    int thirdNumber = number / 100;
    Console.WriteLine(thirdNumber);
}

if (number > 100 && number < 1000)
{
    int thirdNumber = number / 100;
    Console.WriteLine(thirdNumber);
}

if (number > 10 && number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите число от 1 до 7:  ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number == 1)
{
    Console.WriteLine("Будний");
}
else if (number == 2)
{
    Console.WriteLine("Будний");
}
else if (number == 3)
{
    Console.WriteLine("Будний");
}
else if (number == 4)
{
    Console.WriteLine("Будний");
}
else if (number == 5)
{
    Console.WriteLine("Будний");
}
else if (number == 6)
{
    Console.WriteLine("Выходной");
}
else if (number == 7)
{
    Console.WriteLine("Выходной");
}