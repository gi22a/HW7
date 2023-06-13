// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CraeteArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 50);
        }
    }
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CearcAverage(double[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            average = average + arr[i, j] / arr.GetLength(1);
        }
        Console.WriteLine($"Средне арифметическое = {Math.Round(average, 1)}");
    }
}
//i = 0, j = 0, 1, 2 ..sum += sum / GetLength(1)
Console.Write("Введите число M: ");
int row = InputNumber();
Console.Write("Введите число N: ");
int colums = InputNumber();

double[,] array = new double[row, colums];
CraeteArray(array);
PrintArray(array);
CearcAverage(array);