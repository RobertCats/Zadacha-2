//Задача № 43

Console.Write("Имеется два уравнения:");
Console.WriteLine("Уравнение № 1: y = k1 * x + b1");
Console.WriteLine("Уравнение № 2: y = k2 * x + b2");
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Уравнение №1:");
Console.WriteLine($"y = {k1} * x + {b1}");
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Уравнение №2:");
Console.WriteLine($"y = {k2} * x + {b2}");
float x = (float) (b2 - b1) / (k1 - k2);
float y = (float) k1 * (b2 - b1) / (k1 - k2) + b1;
Console.Write($"Точки пересечения:({x};{y})");
