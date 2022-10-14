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
    int i = 0;

    foreach (int el in arr)
    {

        arr[i] = arr[i] * -1;
        Console.Write($"{arr[i]} ");
        i++;
    }


}