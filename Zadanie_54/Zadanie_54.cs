//Задача № 54

Console.Write("Строка:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец:");
int columns = Convert.ToInt32(Console.ReadLine());

int[ , ] m = new int [rows,columns];

Console.Write("Матрица:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        m[i,j] = new Random().Next(10);
        Console.Write(m[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Итоговая матрица");
for (int i = 0; i < rows; i++)
{
    int[] array = new int[columns];
    for (int j = 0; j < columns; j++)
    {
        array[j] = m[i,j];
        Array.Sort(array);
        Array.Reverse(array);
    }
    Console.WriteLine(String.Join("\t", array));
    Console.WriteLine();
}