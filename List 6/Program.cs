//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
//Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < numbers.GetLength(1) - 1; k++)
        {
            if (numbers[i, k] < numbers[i, k + 1]) 
            {
                int temp = 0;
                temp = numbers[i, k];
                numbers[i, k] = numbers[i, k + 1];
                numbers[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
    }
}*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

/*int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputNumbers("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);*/



//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*int dimension1 = InputInt("Введите размерность 1: ");
int dimension2 = InputInt("Введите размерность 2: ");
int dimension3 = InputInt("Введите размерность 3: ");
int countNumbers = 89;

if(dimension1 * dimension2 * dimension3 > countNumbers)
{
  Console.WriteLine("Массив слишком большой!");
  return;
}

int[,,] CreateArray(int size1, int size2, int size3)
{
  int[,,] array = new int[size1, size2, size3];
  int[] digitValues = new int[countNumbers];
  int value = 10;
  for(int i = 0; i < digitValues.Length; i++)
  {
    digitValues[i] = value++;

      for(int i = 0; i < digitValues.Length; i++)
      {
        int randomIndex = new Random().Next(0, digitValues.Length);
        int temp = digitValues[i];
        digitValues[i] = digitValues[randomIndex];
        digitValues[randomIndex] = temp;
      }
  }
int valueIndex = 0;
  for(int i = 0; i < array.GetLength(0); i++)
  {
     for(int j = 0; j < array.GetLength(1); j++)
     {
        for(int k = 0; k < array.GetLength(2); k++)
          {
           array[i, j, k] = digitValues[valueIndex++];
          }
    }
  }

return array;
}

int InputInt(string output)
{
  Console.Write(output);
  return int.Parse(Console.ReadLine());
}*/

//Задача 62: Заполните спирально массив 4 на 4.

/*Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];

int value = 1;
int i = 0;
int j = 0;

while(value <= n * n)
{
  array[i, j] = value;
  if(i <= j + 1 && i + j < n - 1)
  {
     ++j;
  }
  else if (i < j && i + j >= n - 1)
  { 
    ++i;
  }
  else if (i >= j && i + j > n - 1)
  {
    --j;
  } 
  else
  {
    --i;
    ++value;
  }
}

for(int x = 0; x < array.GetLength(0); x++)
{
  for(int y = 0; y < array.GetLength(1); y++)
  {
     Console.Write(array[x, y] + " ");
  }
  Console.WriteLine();
}*/
