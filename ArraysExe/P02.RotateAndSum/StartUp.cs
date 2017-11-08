using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.RotateAndSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[arr.Length];

            //int[] rotated = new int[arr.Length];
            //int index = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    rotated[(i + rotations) % rotated.Length] = arr[i];
            //    index++;
            //}

            for (int i = 0; i < rotations; i++)
            {
                int[] rotated = new int[arr.Length];
                int index = 0;
                for (int k = 0; k < arr.Length; k++)
                {
                    rotated[(k + i) % rotated.Length] = arr[k];
                    index++;
                    sum[i] += arr[i];
                }
            }

            for (int r = 0; r < arr.Length; r++)
            {
                Console.WriteLine(String.Join(" ", sum[r]));
            }

               
        }


    }
}
