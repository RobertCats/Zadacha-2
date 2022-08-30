//Задача № 41

Console.Write("Введите числа:");
int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
int Count = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0) Count++;
}
Console.Write($"Числа больше нуля: {Count}");