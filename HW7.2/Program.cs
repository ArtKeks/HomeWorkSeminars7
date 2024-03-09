        static int Ack(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
             if (n == 0)
            {
                return Ack(m - 1, 1);
            }
            else
            {
                return Ack(m - 1, Ack(m, n - 1));
            }
        }

             Console.WriteLine("Введите неотрицательное целое число m:");
            int m = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Введите неотрицательное целое число n:");
            int n = int.Parse(Console.ReadLine()!);

            int result = Ack(m, n);
            Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно: {result}");
    