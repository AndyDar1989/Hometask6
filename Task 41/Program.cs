/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

int CountPos(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}

int[] NonRandomNumb(int n)
{
    int[] array = new int[n];
    Console.WriteLine("Enter numbers: ");
    for (int i = 0; i < n; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}

Console.Write("Enter count of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = NonRandomNumb(size);
int result = CountPos(arr);
Console.WriteLine($"The count of positive numbers: {result}");

/*void NonRandomNumbers()
{
    Console.Write("Enter numbers separated by spaces: ");
    string? numbers;
    if ((numbers = Console.ReadLine()) != null)
    {
        int[] array = numbers.Split(' ').Select(Int32.Parse).ToArray();
        int res = CountPos(array);
        Console.WriteLine($"The count of positive numbers: {res}");
    }
}

NonRandomNumbers();*/