using System;

namespace PesanRahasia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NO 1 : PESAN RAHASIA");
            Console.WriteLine("Input : ");
            string input = Console.ReadLine();
            pesan_rahasia(input);
            Console.ReadLine();
        }

        static void pesan_rahasia(string input)
        {
            int L = input.Length;
            while (L > 1000)
            {
                Console.WriteLine("Pesan tidak boleh lebih dari 1000 karakter!");
                Console.WriteLine("Input : ");
                input = Console.ReadLine();
                L = input.Length;
            }
            double result = Math.Sqrt(L);
            int K = Convert.ToInt32(result), M = 0, count = 0;
            bool isSquare = result % 1 == 0;
            if (!isSquare)
            {
                K = (int)result + 1;
            }
            M = K * K;
            for (int i = 0; i < M - L; i++)
            {
                input += "*";
            }
            char[] arr = input.ToCharArray();
            char[,] inputan = new char[K, K];
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    inputan[i, j] = arr[count];
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Output : ");
            for (int i = 0; i < K; i++)
            {
                for (int j = K - 1; j >= 0; j--)
                {
                    if (inputan[j, i] != '*')
                        Console.Write(inputan[j, i]);
                }
            }
        }
    }
}
