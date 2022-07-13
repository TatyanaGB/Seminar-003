//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*double Input (string output)
{
  Console.Write(output);
  return Convert.ToDouble(Console.ReadLine());
}

void PrintArray(double [,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
    {
      for(int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }  
}

double m = Input ("Введите m: ");
double n = Input ("Введите n: ");
double[,] numbers = new double[m, n];

for(int i = 0; i < numbers.GetLength(0); i++)
{
  for(int j = 0; j < numbers.GetLength(1); j++)
    {
      numbers [i, j]  = new Random().Next(1, 10);
    }
}
PrintArray(numbers);*/

///Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

/* Input (string output)
{
  Console.Write(output);
  return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int [,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
    {
      for(int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int m = Input ("Введите m: ");
int n = Input ("Введите n: ");
int[,] numbers = new int[m, n];

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
      numbers [i, j]  = new Random().Next(1, 10);
    }
}    
PrintArray(numbers);

int searchNumbers = Convert.ToInt32(Console.ReadLine());

if (SearchNumber (numbers, searchNumbers)) 
{ 
  Console.WriteLine("Такое число есть");
}
else
{
    Console.WriteLine("Такого числа нет");
}

bool SearchNumber(int[,] array, int numbers)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
      for(int j = 0; j < array.GetLength(1); j++)
      {
        if(array[i, j] == numbers)
        return true;
      }
   }
   return false;
}*/

//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*Input (string output)
{
  Console.Write(output);
  return Convert.ToInt32(Console.ReadLine());
}  

int[,] line = Input("Введите количество строк: ");
int[,] column = Input("Введите количество столбцов: ");
int [,] array = new int[line, column];

for(int i = 0; i < array.GetLength(0); i++)
    {
      float  columnAvg = 0;
      for(int j = 0; j < array.GetLength(1); j++)
        {
          columnAvg += array[i,j];
          columnAvg =  columnAvg / line;
        }   
    } 
 PrintArray(array);
 Console.Write("columnAvg = " + columnAvg)

void PrintArray(int [,] array);
{
  for(int i = 0; i < array.GetLength(0); i++)
    {
      for(int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }    
}*/



