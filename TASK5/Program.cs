//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
/*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

Console.Clear();
int[] ourArray = FillArray(123, 0, 999);
FindNumbersFrom10To99(ourArray);


int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    //Console.WriteLine("массив");
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
        //Console.Write($"{arr[i]} ");
    }

    return arr;
}

void FindNumbersFrom10To99(int[] arr)
{
    int i =0;
    foreach( int el in arr)
    {
        if (el >= 10 && el<=99)
        {
            i++;

        }
    }
    Console.WriteLine($"\nчисло элементов от 10 до 99 = {i}");
}

