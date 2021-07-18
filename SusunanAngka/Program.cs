using System;

namespace SusunanAngka
{
    class Program
    {
        static void cariSusunanAngka(int[] array, int index, int num, int sisa)
        {
            if (sisa < 0)
                return;

            if (sisa == 0)
            {
                for (int i = 0; i < index; i++)
                    Console.Write(array[i] + " ");
                Console.WriteLine();
                return;
            }

            int prev = (index == 0) ?
                                1 : array[index - 1];

            for (int k = num; k >= prev; k--)
            {
                array[index] = k;
                cariSusunanAngka(array, index + 1, num,
                                        sisa - k);
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("NO 2 : SUSUNAN ANGKA");
            Console.Write("Input a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[num];
            cariSusunanAngka(array, 0, num, num);
            Console.ReadLine();
        }
    }
}
