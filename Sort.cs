using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021101106
{
    class Sort
    {
        static public void InterchangeSort(int[] arr, int N)
        {
            int i, j, temp;
            int k = 1;
            for (i = 0; i < N - 1; i++)
            {
                for(j=i+1;j< N; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.WriteLine($"\n Vong lap {k++}: " + string.Join(",", arr));
            }
        }
        static public void BubbleSort(int[] arr , int N)
        {
            int temp;
            int k = 1;
            for(int i = N - 1; i > 0; i--)
            {
                for(int j=0;j< i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                Console.WriteLine($"\n Vong lap {k++}: " + string.Join(",", arr));
            }
        }
    }
}
