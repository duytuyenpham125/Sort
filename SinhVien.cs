using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021101106
{
    class SinhVien
    {
        public string Ten { get; set; }
        public string MSSV { get; set; }
        public double DTB { get; set; }

        public SinhVien(string ten, string mssv, double diem)
        {
            Ten = ten;
            MSSV = mssv;
            DTB = diem;
        }
        public void  ToString()
        {
            Console.WriteLine($"MSSV: {MSSV}, Ten: {Ten}, Diem Trung Binh: {DTB}");
        }

    }
}
