using System;

namespace testTasl
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 1, 2, 3, 5, 4 };
            for (int i = 0; i < array.Length; i++)
            {
                int ex = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        ex = 1;
                        break;
                    }
                }
                if (ex == 0)
                    Console.WriteLine(array[i]);
            }
        }
    }
}
