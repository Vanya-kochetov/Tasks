using System;

class Test
{
    static void Main()
    {
        int[,] m = new int[5, 5];
        int i, j;
        for (i = 0; i < 5; i++)
            for (j = 0; j < 5; j++)
            {
                Console.WriteLine("Введите a[{0},{1}]:", i, j);
                m[i, j] = int.Parse(Console.ReadLine());
            }
        bool flag = true;
        for (i = 0; i < 5; i++)
            for (j = 0; j < 5; j++)
                if (m[i, j] != m[j, i])
                    flag = false;
        if (flag)
            Console.WriteLine("Симметрична");
        else
            Console.WriteLine("Не симметрична");
        Console.WriteLine("Вывод матрицы :");
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 5; j++)
                Console.Write(m[i, j].ToString() + "\t");
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
