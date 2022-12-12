Console.Clear();
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] number = new int[M];

for (int i = 0; i < M; i++)
{
Console.Write($"Введи число {i+1}: ");
number[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
for (int i = 0; i < number.Length; i++)
{
if (number[i] > 0)
count++;
}
Console.WriteLine($"Введено чисел больше 0: {count}");