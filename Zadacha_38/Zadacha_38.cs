 //Задание № 38

Console.Write("Кол-во чисел элементов в массиве?: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[Num1];
double result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    Random rnd = new Random();
    numbers[i] = rnd.NextDouble();
    Console.Write(numbers[i] + "\t");
}
result = numbers.Max() - numbers.Min();
Console.Write($"\n Разница между максимальным и минимальным элементом массива: {result}");
