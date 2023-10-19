// 1 Вариант 
// 1

var array = new int[10] { 1, 2, 3, 1, 11, 6, 7, 8, 9, 10 };
var min = -100000;
var max = 1000000;
var sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > min)
        min = array[i];
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < max)
        max = array[i];
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] != min && array[i] != max)
    {
        sum += array[i];
    }
}

Console.WriteLine($"Сумма без элементов массива без max и мин элемента {sum}");

var c = 2 + 3 + 6 + 7 + 8 + 9 + 10;
Console.WriteLine($"Проверка {c}");

// 3

Random r = new Random();
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
if (n != m)
{
    Console.WriteLine("Можно транспонировать только квадратные матрицы");
}

int[,] matr = new int[n,m];
for (int i = 0; i < n; i++ )
{
    for (int j = 0; i < j; j++)
    {
        matr[i, j] = r.Next(100);
        Console.WriteLine($"Изначальная матрица {matr[i, j]}");
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; i < j; j++)
    {
        matr[i, j] = matr[j, i];
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; i < j; j++)
    {
        Console.WriteLine($"Транспонированная матрица {matr[i, j]}");
    }
}