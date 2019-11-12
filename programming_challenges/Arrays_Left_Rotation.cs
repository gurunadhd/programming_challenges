using System;
using System.IO;

namespace programming_challenges
{
    class Arrays_Left_Rotation
    {
        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] rotArray = new int[a.Length];

            if (d > a.Length)
            {
                d = d - a.Length;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (i + d < a.Length)
                {
                    rotArray[i] = a[i + d];
                }
                else
                {
                    rotArray[i] = a[i + d - a.Length];
                }
            }

            return rotArray;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));

            //textWriter.WriteLine(string.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
