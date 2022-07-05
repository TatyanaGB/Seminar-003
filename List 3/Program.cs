//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*int[] array = new int[999];
int sum = 0;
int size = array.Length;
FillArrayRandomNumbers(array);
PrintArray(array);

for(int i = 0; i < array.Length; i++)
{
   if(size % 2 == 0)
   sum += size;
}
Console.WriteLine($"Сумма четных = {sum}");

void PrintArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
       {
          Console.Write(array[i] + " ");
       }
Console.WriteLine();
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
       {
          array[i] = new Random().Next(100, 1000);
       }
}*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*int size = InputInt("Введите размер массива: ");
int[] array = CreateArray(size);
int sum = 0;
PrintArray(array);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = InputInt("Введите элемент " + i + ": ");
    }
    return array;
}

 int InputInt(string outout)
{
    Console.Write(outout);
    return Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < array.Length; i+=2)
{
   if(array[i] % 2 == 1)
   sum += array[i];
}
Console.WriteLine($"Сумма нечетных = {sum}");

void PrintArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
     {
         Console.Write(array[i] + " ");
     }
Console.WriteLine();
}*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] numbers = {3, 7, 22, 2, 78};
double min = numbers[0];
double max = numbers[0];
PrintArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
       if(min > numbers[i])
       {
            min = numbers [i];
            Console.WriteLine(min);
       }

       if(max < numbers[i])
       {
            max = numbers [i];
            Console.WriteLine(max);
       }
     Console.WriteLine(max - min);
}
     
void PrintArray(double[] numbers)
{
    for(double i = 0; i < numbers.Length; i++)
          {
            Console.Write(numbers + " ");
          }
Console.WriteLine();
}