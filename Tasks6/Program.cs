Console.WriteLine("Дана матрица A(MxN)");
Console.Write("M=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] k = new int[m, n];
Random r = new Random();
Console.WriteLine();

Console.WriteLine("Исходная матрица:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        k[i, j] = r.Next(1, 10);
        Console.Write(k[i, j] + " ");
    }
    Console.WriteLine();
}

int Imax = 0, Jmax = 0;
for (int i = 0; i < m; i++)
{
    int max = k[i, 0];
    for (int j = 0; j < n; j++)
    {
        if (k[i, j] > max) { max = k[i, j]; Imax = i; Jmax = j; }
    }

    int z = k[Imax, Jmax];
    k[Imax, Jmax] = k[i, i];
    k[i, i] = z;

    Imax = i + 1; Jmax = 0;
}
Console.WriteLine();

Console.WriteLine("Преобразованная матрица:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(k[i, j] + " ");
    }
    Console.WriteLine();
}
Console.ReadKey();


