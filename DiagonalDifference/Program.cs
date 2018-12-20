using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int[] {1,2,3},
                new int[] {6,5,9},
                new int[] {7,8,4},
            };

            //Console.WriteLine(arr[0,1]);
            //Console.WriteLine(arr.GetLength(0));
            //Console.WriteLine(arr.GetLength(1));

            var totalRows = arr.GetLength(0);
            var totalColumns = arr[0].Count();


            var primarySum = 0;
            var secondarySum = 0;

            // find primarySum
            for (var i = 0; i < totalRows; i++)
            {
                for (var j = 0; j < totalColumns; j++)
                {
                    // always going to be first row first col for primarySum
                    // second row second col for primarySum
                    if (i == j)
                    {
                        primarySum += arr[i][j];
                    }
                }
            }

            // find secondarySum
            for (var i = 0; i < totalRows; i++)
            {
                // reverse the each inner array
                Array.Reverse(arr[i]);

                for (var j = 0; j < totalColumns; j++)
                {
                    // after reverse the array
                    // always going to be first row first col for secondarySum too
                    // second row second second col  for secondarySum too
                    if (i == j)
                    {
                        secondarySum += arr[i][j];
                    }
                }
            }

            // find difference
            var difference = Math.Abs(primarySum - secondarySum);

            Console.WriteLine(primarySum);
            Console.WriteLine(secondarySum);
            Console.WriteLine(difference);
        }
    }
}
