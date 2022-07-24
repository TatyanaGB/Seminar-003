//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.


/*int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int n = InputNumbers("Введите n: ");
int count = 2;
NaturalNumber(n, count);
Console.Write(1);

void NaturalNumber(int n, int count)
{
  if (count > n) return;
  NaturalNumber(n, count + 1);
  Console.Write(count + ", ");
}*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.


/*Console.WriteLine("Введите значение M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение N:");
int numberN = int.Parse(Console.ReadLine());

void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

       
/*int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Funct(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Funct(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Funct(m - 1, 1);
  else return Funct(m - 1, Funct(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}*/