 //Задание № 34

Console.Write("Введите число:");
int Num = Convert.ToInt32(Console.ReadLine());
int SumIndex = 0;
int[] arr = new int[Num];
Random rand = new Random();
for(int i =0;i<arr.Length;i++)
{
arr[i] = rand.Next(1,1000);
    if (arr[i] % 2 == 0)
    {
        Console.WriteLine(arr[i]);
        SumIndex += 1;
    } 
    }
Console.Write("Массив:");
Console.Write($"[{String.Join("; ", arr)}]");
Console.WriteLine($"Четных чисел в массиве: {SumIndex}");
