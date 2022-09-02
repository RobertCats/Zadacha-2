//Задача № 52

Console.Write("Введите строки, столбцы в массиве.");
Console.Write("Введи m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        numbers[i, j] = new Random().Next(101);
        Console.Write("|" + numbers[i, j] + "|" + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    int sum = 0;
    for (int j = 0; j < m; j++)
    {
        sum += numbers[j, i];
    }
    double avg = (double) sum / m;
    Console.WriteLine($"Элементы столбца {i} равно {avg}");
}