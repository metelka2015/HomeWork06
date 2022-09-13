// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.Clear();

int NumbersGreaterThanZero(int[] number)
{
    int result = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0) result++;
    }
    Console.WriteLine("\nЧисел больше нуля: " + result);
    return result;
}

void Massive(int[] input)
{
    Console.WriteLine("Введите числа: ");
    for (int i = 0; i < input.Length; i++)
    {
        input[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine();
}

void PrintMassive(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + ", ");
    }
}

Console.Write("Введите количество чисел для проверки: ");
int n = int.Parse(Console.ReadLine()!);
int[] input = new int[n];
Massive(input);
PrintMassive(input);
int result = NumbersGreaterThanZero(input);
