/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

int CountPos(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}


/*Console.Write("Enter count of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("Enter numbers: ");
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int result = CountPos(array);
Console.WriteLine($"The count of positive numbers: {result}");*/


void EnterNumbers()
{
Console.Write("Enter numbers separated by spaces: ");
string? numbers;
if ((numbers = Console.ReadLine()) != null)
{
    int[] array = numbers.Split(' ').Select(Int32.Parse).ToArray();
    int result = CountPos(array);
    Console.WriteLine($"The count of positive numbers: {result}");
}
}



EnterNumbers();

