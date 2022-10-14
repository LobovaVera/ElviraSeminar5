// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

/*const int SIZE = 12;
int[] ourArray = new int [SIZE];*/

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

int[] ourArray = FillArray(12, -9, 9);
int negativeSum = 0;
int positiveSum = 0;
foreach (int el in ourArray)
{
    if (el > 0)
    {
        positiveSum += el;
    }
    else
    {
        negativeSum += el;
    }
}
Console.WriteLine();
Console.WriteLine($"negative sum is {negativeSum}, positiveSum is {positiveSum} ");


//int MaxAndMinSumm()
