// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] ourArray = FillArray(12, -9, 9);
SwitchArray(ourArray);


int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    Console.WriteLine("Старый массив");
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{arr[i]} ");
    }

    return arr;
}


void SwitchArray(int[] arr)
{
    Console.WriteLine("\n Новый массив");

    for (int i = 0; i < arr.Length; i++)
    {

        arr[i] = arr[i] * -1;
        Console.Write($"{arr[i]} ");
    }


}

