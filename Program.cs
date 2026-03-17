using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace _021101106
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Console.Write("Chuong trinh do thoi gian hien thi n so nguyen");
            Console.Write("\nNhap vao so n ");

            long N = Convert.ToInt64(Console.ReadLine());
            long[] nums = new long[N];
            BuildArray(nums);

            Stopwatch timer = new Stopwatch();
            Console.Write("Go phim bat ki de bat dau....");
            

            timer.Start();
            DisplayNums(nums);
            timer.Stop();

            Console.Write("\n\n ket thuc do thoi gian");
            long ms = timer.ElapsedMilliseconds;
            Console.Write("\nKet qua do: T= {0} mili giay", ms.ToString());


            Console.Read();


        }

        static void BuildArray(long[] arr)
        {
            for (long i = 0; i < arr.Length; i++)
                arr[i] = i;
        }

        static void DisplayNums(long[] arr)
        {
            for (long i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
        */

        
        struct NhanVien
        {
            public string Hoten;
            public string Manv;
            public double HSL;

            public void ToString()
            {
                Console.WriteLine($"HoTen: {Hoten}, Ma Nhan Vien: {Manv}, He So Luong: {HSL}. ");
            }
        }

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




            Console.WriteLine("Before Swap NhanVien");
            NhanVien nv1;
            nv1.Hoten = "Pham Duy Tuyen";
            nv1.Manv = "NV001";
            nv1.HSL = 1.5;
            nv1.ToString();


            Console.WriteLine("\nAfter Swap NhanVien");
            NhanVien nv2;
            nv2.Hoten = "Pham Duy POtj";
            nv2.Manv = "NV002";
            nv2.HSL = 2.5;
            nv2.ToString();

            Swap<NhanVien>(ref nv1, ref nv2);

            Console.WriteLine("\nAfter Swap:");
            nv1.ToString();
            nv2.ToString();

            Console.WriteLine("\n--------------------------------------------");


            Console.WriteLine("\nBefore Swap Sinh Vien");
            SinhVien sv1 = new SinhVien("Potj","021101106",90);
            SinhVien sv2 = new SinhVien("Tuyen", "021101107", 50);
            sv1.ToString();
            sv2.ToString();


            Swap<SinhVien>(ref sv1, ref sv2);
            Console.WriteLine("\nAfter Swap Sinh Vien");
            sv1.ToString();
            sv2.ToString();

            Console.WriteLine("\n--------------------------------------------");



            int[] a = { 10, 5, 1, 3, 4, 15, 1, 7, 8, 12 };
            int[] b = { 2, 8, 4, 56, 4, 11, 54, 26, 100, 5 };
            int[] ac = (int[])a.Clone();

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
            Sort.QuickSort(ac,0,ac.Length-1);
            Sort.DisplayElements(ac, ac.Length);

            Console.WriteLine("\n--------------------------------------------");
            Console.Write("\n\n Mang sap xep tang theo giai thuat sap xep vun dong la:\t");
            Sort.HeapSort(ac, ac.Length - 1);
            Sort.DisplayElements(ac, ac.Length);


             Console.Read();
        }
    }
}
