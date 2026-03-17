using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class Sort
    {
        static public void DisplayElements(int[] a, int N)
        {
            for (int i = 0; i < N; i++)
                Console.Write(a[i] + " ");
        }
        static public void InterchangeSort(int[] arr, int N)
        {
            int i, j, temp;
            int k = 1;
            for (i = 0; i < N - 1; i++)
            {
                for (j = i + 1; j < N; j++)
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
        static public void BubbleSort(int[] arr, int N)
        {
            int temp;
            int k = 1;
            for (int i = N - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
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
        static public void BubbleSortDecrease(int[] arr, int N)
        {
            int temp;
            int k = 1;
            for (int i = N - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                Console.WriteLine($"\n Vong lap {k++}: " + string.Join(",", arr));
            }
        }
        static public void ShakerSort(int[] arr, int N)
        {
            int temp;
            int left = 0, right = N - 1, k = N - 1;
            int i, j = 0;
            int m = 1;
            while (left < right)
            {
                for (j = right; j > left; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        k = j;
                    }
                }
                left = k;
                Console.WriteLine("\n DUyet nguoc");
                Console.Write($"{m}a:\t" + string.Join(",", arr));
                for (i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        k = i;
                    }
                }
                right = k;
                Console.WriteLine("\n DUyet xuoi");
                Console.Write($"{m}b:\t" + string.Join(",", arr));
                m++;
            }
        }
        static public void SelectionSort(int[] arr, int N)
        {
            int temp;
            int imin;
            int k = 1;
            for (int i = 0; i < N-1; i++)
            {
                imin = i;
                for (int j = i+1; j < N; j++)
                {
                     if (arr[j] < arr[imin])
                        imin = j;
                }
                temp = arr[i];
                arr[i] = arr[imin];
                arr[imin] = temp;
                Console.WriteLine($"\n Vong lap {k++}: " + string.Join(",", arr));
            }
        }
        static public void SelectionSortDecrease(int[] arr, int N)
        {
            int temp;
            int imax;
            int k = 1;
            for (int i = 0; i < N - 1; i++)
            {
                imax = i;
                for (int j = i + 1; j < N; j++)
                    if (arr[j] > arr[imax])
                        imax = j;

                temp = arr[i];
                arr[i] = arr[imax];
                arr[imax] = temp;
                Console.WriteLine($"\n Vong lap {k++}: " + string.Join(",", arr));
            }
                    
            
        }
        static public void InsertionSort(int[] arr, int N)
        {
            int j, x ;
            int k = 1;
            for (int i = 1; i < N; i++)
            {
                x = arr[i];
                j = i - 1;
                while (j>=0 && arr[j] > x)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = x;
                Console.WriteLine($"\n Vong lap {k++}: " + string.Join(",", arr));
            }
        }
        static public void InsertionSortDecrease(int[] arr, int N)
        {
            int j, x;
            int k = 1;
            for (int i = 1; i < N; i++)
            {
                x = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] < x)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = x;
                Console.WriteLine($"\n Vong lap {k++}: " + string.Join(",", arr));
            }
        }
        static public void QuickSort(int[] arr, int left, int right)
        {
            int temp;
            int x = arr[(left + right) / 2];
            int i = left;
            int j = right;
            while (i< j)
            {
                while (arr[i] < x)
                    i++;
                while (arr[j] > x)
                    j--;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                    j--;
                }

            }
            if (left < j)
                QuickSort(arr, left, j);
            if (i < right)
                QuickSort(arr, i, right);
        }
        static public void AdjustHeap(int[] arr, int iRoot, int iEnd)
        {
            int saved = arr[iRoot];
            int i = iRoot;
            int j = 2 * i + 1;
            while(j<=iEnd)
            {
                if ((j + 1 <= iEnd) && arr[j] <= arr[j + 1])
                    j += 1;
                if (arr[j] <= saved)
                    break;

                else
                {
                    arr[i] = arr[j];
                    arr[j] = saved;
                    i = j;
                    j = 2 * i + 1;
                }
            }
            Console.Write("\n\t Hieu chinh dong day tu chi so " + iRoot + " den " + iEnd + ":");
            DisplayElements(arr, arr.Length);
            Console.WriteLine();
        }

        public static void CreateHeap(int[] arr, int N)
        {
            Console.Write("\n GIAI DOAN 1. Tao dong cho mang\n");
            int iRoot;
            for (iRoot = ((int)N / 2) - 1; iRoot >= 0; iRoot--)
                AdjustHeap(arr, iRoot, N - 1);
        }
        public static void HeapSort(int[] arr, int N)
        {
            CreateHeap(arr, N);
            Console.Write("\n GIAI DOAN 2.LAP: HOAN VI 2 PHAN TU VA HIEU CHINH DONG\n");
            int temp;
            int iEnd = N - 1;
            while (iEnd > 0)
            {
                temp = arr[0];
                arr[0] = arr[iEnd];
                arr[iEnd] = temp;

                Console.Write("\n\t Hoan vi phan tu chi so 0 voi chi so " + iEnd + ":");
                DisplayElements(arr, arr.Length);
                Console.WriteLine();
                iEnd -= 1;
                AdjustHeap(arr, 0, iEnd);

            }
            Console.Write("\n 2.Mang sau khi sap xep: ", arr);
        }
    }
}
