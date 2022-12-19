using System;

namespace mynamespase
{
    class Program
    {
        public static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int number;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        number = arr[i];
                        arr[i] = arr[j];
                        arr[j] = number;
                    }
                }
            }
            foreach(var itm in arr)
            {
                Console.Write(itm);
            }
        }
    }
}