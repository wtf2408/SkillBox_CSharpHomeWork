#region Задание 1
//Напишите метод, реализующий подсчёт суммы чётных чисел в диапазоне от 7 до 21

int SumEvenNumbers(int num1, int num2)
{
    int sum = 0;
    for (; num1 < num2 + 1; num1++)
    {
        if (num1 % 2 == 0)
            sum += num1;
    }
    return sum;
}
Console.WriteLine(SumEvenNumbers(7, 21));
#endregion

#region Задание 2
//Напишите метод, реализующий подсчёт суммы чётных чисел в заданном массиве,
//и выведите в консоль результат.
int[] arr = { 1, 3, 4, 2, 6, 7, 5, 9 };
int SumEvenNumbersInArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            sum += arr[i];
    }
    return sum;
}
Console.WriteLine(SumEvenNumbersInArray(arr));
#endregion

#region Задание 3
//Напишите метод, реализующий поиск первого вхождения числа в массив,
//и выведите в консоль его индекс или -1, если число не найдено.
int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
Console.WriteLine(IndexNumberInArray(array, 8));
int IndexNumberInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return i;
    }
    return -1;
}
#endregion

#region Задание 4
int[] numbers = { 1, 6, 5, 7, 4, 3, 11, 4, 7, 1 };
SortingChoice(numbers);
foreach (int item in numbers)
{
    Console.WriteLine($"{item} ");
}
Console.ReadKey();
void SortingChoice(int[] arr)
{
    int min;
    int minIndex;
    int temp;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        min = arr[i];
        minIndex = i;
        for (int j = 1 + i; j < arr.Length; j++)
        {
            if (arr[j] < min)
            {
                min = arr[j];
                minIndex = j;
            }
        }
        temp = arr[i];
        arr[i] = min;
        arr[minIndex] = temp;
    }
}
#endregion