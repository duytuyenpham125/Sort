using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Sorter;
namespace _021101106
{
    class Program
    {

        public static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
        static void DisplayElements(int[] a, int N)
        {
            for (int i = 0; i < N; i++)
                Console.Write(a[i] + " ");
        }
        static void Main(string[] arg)
        {

            int[] a = { 10, 5, 1, 3, 4, 15, 1, 7, 8, 12 };
            int[] b = { 2, 8, 4, 56, 4, 11, 54, 26, 100, 5 };
            int[] ac = (int[])a.Clone();

            Console.Write("\n\n 1. Sort or 2. Search:\t");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.Write("\n\n Mang sap xep tang theo giai thuat truc tiep la:\t");
                    Sort.InterchangeSort(a, a.Length);
                    Sort.DisplayElements(a, a.Length);
                    Console.WriteLine("\n--------------------------------------------");

                    Console.Write("\n\n Mang sap xep tang theo giai thuat noi bot tang dan la:\t");
                    Sort.BubbleSort(b, b.Length);
                    Sort.DisplayElements(b, b.Length);
                    Console.WriteLine("\n--------------------------------------------");

                    Console.Write("\n\n Mang sap xep tang theo giai thuat noi bot giam dan la:\t");
                    Sort.BubbleSortDecrease(b, b.Length);
                    Sort.DisplayElements(b, b.Length);
                    Console.WriteLine("\n--------------------------------------------");

                    Console.Write("\n\n Mang sap xep tang theo giai thuat rung lac la:\t");
                    Sort.ShakerSort(ac, ac.Length);
                    Sort.DisplayElements(ac, ac.Length);

                    Console.WriteLine("\n--------------------------------------------");
                    Console.Write("\n\n Mang sap xep tang theo giai thuat chen tang dan la:\t");
                    Sort.InsertionSort(ac, ac.Length);
                    Sort.DisplayElements(ac, ac.Length);
                    Console.WriteLine("\n--------------------------------------------");
                    Console.Write("\n\n Mang sap xep tang theo giai thuat chen giam dan la:\t");
                    Sort.InsertionSortDecrease(ac, ac.Length);
                    Sort.DisplayElements(ac, ac.Length);

                    Console.WriteLine("\n--------------------------------------------");
                    Console.Write("\n\n Mang sap xep tang theo giai thuat sap xep chon tang dan la:\t");
                    Sort.SelectionSort(ac, ac.Length);
                    Sort.DisplayElements(ac, ac.Length);

                    Console.WriteLine("\n--------------------------------------------");
                    Console.Write("\n\n Mang sap xep tang theo giai thuat sap xep chon giam dan la:\t");
                    Sort.SelectionSortDecrease(ac, ac.Length);
                    Sort.DisplayElements(ac, ac.Length);

                    Console.WriteLine("\n--------------------------------------------");
                    Console.Write("\n\n Mang sap xep tang theo giai thuat sap xep nhanh la:\t");
                    Sort.QuickSort(ac, 0, ac.Length - 1);
                    Sort.DisplayElements(ac, ac.Length);

                    Console.WriteLine("\n--------------------------------------------");
                    Console.Write("\n\n Mang sap xep tang theo giai thuat sap xep vun dong la:\t");
                    Sort.HeapSort(ac, ac.Length - 1);
                    Sort.DisplayElements(ac, ac.Length);
                    break;
                case 2:
                    
                    Console.Write("\n\n Nhap so phan tu trong mang: \t");
                    int N = int.Parse(Console.ReadLine());
                    int[] searchArr = new int[N];
                    
                    for(int i=0;i< N; i++)
                    {
                        Console.Write($"a[{i}]");
                        searchArr[i] = int.Parse(Console.ReadLine());
                    }
                    
                    Console.Write("\n\n Nhap phan tu can tim: \t");
                    int X = int.Parse(Console.ReadLine());
                    int result1 = Search.SeqSearch(searchArr, N, X);
                    Console.Write($"Phan Tu {X} nam o vi tri thu {result1 +1}");

                    Console.Write("\n-------------------------------------------");
                    Console.Write("\n\n Nhap phan tu can tim: \t");
                    int X2 = int.Parse(Console.ReadLine());
                    int result2 = Search.SeqSearchAtLast(searchArr, N, X2);
                    Console.Write($"Phan Tu {X2} nam o vi tri thu {result2}");

                    Console.Write("\n-------------------------------------------");
                    Console.Write("\n\n Nhap phan tu can tim: \t");
                    int X3 = int.Parse(Console.ReadLine());
                    int result3 = Search.SeqSearchAllX(searchArr, N, X3);
                    Console.Write($"Phan Tu co gia tri {X3}:  {result3}");
                    
                    Console.Write("\n-------------------------------------------");
                    int result4 = Search.SeqSearchFindFirstMin(searchArr, N);
                    Console.Write($"\nPhan Tu nho nhat dau tien tai vi tri: {result4}");

                    Console.Write("\n-------------------------------------------");
                    int result5 = Search.SeqSearchFindLastMax(searchArr, N);
                    Console.Write($"\nPhan Tu lon nhat sau cung tai vi tri: {result5}");

                    Console.Write("\n-------------------------------------------");
                    int result6 = Search.SeqSearchAllMin(searchArr, N);
                    Console.Write($"\nTat ca ca phan tu nho nhat : {result6}");

                    Console.Write("\n-------------------------------------------");
                    int result7 = Search.SeqSearchFirstMaxEven(searchArr, N);
                    Console.Write($"\nPhan Tu le lon nhat dau tien tai vi tri: {result7}");

                    Console.Write("\n-------------------------------------------");
                    int result8 = Search.SeqSearchLastOdd(searchArr, N);
                    Console.Write($"\nPhan Tu chan lon nhat sau cung tai vi tri: {result8}");
                    break;
            }
            Console.Read();
        }
    }
}
