Console.Clear();

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double n1 = -(b1 - b2);
double n2 = k1 - k2;
double x = n1 / n2;
double y = k1 * x + b1; 

Console.WriteLine($"Пересечение в точке: ({x};{y})");








