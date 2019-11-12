using System;
using System.Collections.Generic;
using System.Text;

namespace programming_challenges
{
    class New_Year_Chaos
    {
        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            int noOfBribes = 0;
           
            for (int i = q.Length - 1; i>0; i--)
            {
                //Console.WriteLine(i);
                if (q[i] != i+1)
                {
                    if((i-1>=0) && q[i-1] == i + 1)
                    {
                        noOfBribes++;
                        //Console.WriteLine("111 " + i);
                        Swap(q, i, i - 1);
                        //Console.WriteLine(string.Join(",", q));
                        //Console.WriteLine("noOfBribes "+ noOfBribes);
                    }
                    else if ((i - 2 >= 0) && q[i - 2] == i + 1)
                    {
                        noOfBribes+=2;
                        //Console.WriteLine("222 " + i);
                        Swap(q, i-1, i - 2);
                        //Console.WriteLine(string.Join(",", q));
                        Swap(q, i, i - 1);
                        //Console.WriteLine(string.Join(",", q));
                        //Console.WriteLine("noOfBribes " + noOfBribes);
                    }
                    else 
                    {
                        //Console.WriteLine("kkk " + i);
                        noOfBribes = -1;
                        break;

                    }

                }
                   
            }
            if (noOfBribes == -1)
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                Console.WriteLine(noOfBribes);
            }
            
        }

        static void Swap(int[] a, int i, int j)
        {
            int temp = a[j];
            a[j] = a[i];
            a[i] = temp;
                         
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                minimumBribes(q);
            }
        }
    }
}
