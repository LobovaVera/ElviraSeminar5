// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/
Console.Clear();
int[] ourArray = FillArray(12, -9, 10);

Console.WriteLine("\n Введите число");
int number = int.Parse(Console.ReadLine()!);
CheckNumber(number, ourArray);

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


void CheckNumber(int num, int[] arr)
{
    string check = "Нет";
    foreach (int el in arr)
    {

        if (el == num)
        {
            check = "Да";
            break;
        }


    }

    Console.WriteLine(check);
}
