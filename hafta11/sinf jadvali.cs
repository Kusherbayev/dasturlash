using System;

class Program
{
    static void Main()
    {
        Console.Write("Qatorlar sonini kiriting: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Ustunlar sonini kiriting: ");
        int m = int.Parse(Console.ReadLine());

        double[,] sinf = new double[n, m];

        // Jadval elementlarini kiritish
        Console.WriteLine("Jadval elementlarini kiriting:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"sinf[{i},{j}] = ");
                sinf[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Har bir ustun bo'yicha o'rtacha qiymat
        Console.WriteLine("\nUstunlar bo'yicha o'rtacha qiymatlar:");

        for (int j = 0; j < m; j++)
        {
            double summa = 0;

            for (int i = 0; i < n; i++)
            {
                summa += sinf[i, j];
            }

            double ortacha = summa / n;

            Console.WriteLine($"{j + 1}-ustun o'rtachasi = {ortacha:F2}");
        }
    }
}
