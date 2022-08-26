 //Задание № 36

Console.Write("Введите число:");
int Num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[Num];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)

    arr[i] = rand.Next(-1000, 1000);

int sumValue = 0;

for (int i = 1; i < arr.Length; i++)

    if (i % 2 != 0)
    {
        sumValue += arr[i];
        Console.WriteLine(arr[i]);
    }
Console.WriteLine($"[{String.Join("; ", arr)}]");
Console.Write($"Сумма элементов: {sumValue}");