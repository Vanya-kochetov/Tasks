namespace ConsoleApplication1
{
    class Massiv
    {
        public static void Array()
        {
            double[,] mass = new double[5, 5];
            double[,] mass2 = new double[5, 5];
            Random rnd = new Random();
            Console.WriteLine("Исходная матрица: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mass[i, j] = rnd.Next(20);
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Double Max = int.MinValue;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (Math.Abs(mass[i, j]) > Max) Max = mass[i, j];
            if (Max == 0)
            {
                Console.WriteLine("Деление на 0 невозможно!");
                return;
            }
            Console.WriteLine("\nВторая матрица: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mass2[i, j] = (mass[i, j] / Max);
                    //Console.Write(mass[i, j]);
                    Console.Write("{0:F2}", mass2[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");

            }
        }

        class Program
        {
            static void Main(string[] args)
            {

                Massiv.Array();
                Console.ReadKey();
            }
        }
    }

}
