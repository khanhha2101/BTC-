using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap01_9033
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            Student[] sinhviens = new Student[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("Nhap SID: ");
                string sid = Console.ReadLine();
                Console.Write("Nhap ho ten: ");
                string ht = Console.ReadLine();
                Console.Write("Nhap khoa: ");
                string kh = Console.ReadLine();
                Console.Write("Nhap dtb: ");
                string dtb = Console.ReadLine();
 
                sinhviens[i] = new Student(sid, ht, kh, dtb);
            }

            Console.WriteLine("\n============DANH SACH SINH VIEN==========");
            for (int i = 0; i<n; i++)
            {
                sinhviens[i].show();
                Console.WriteLine("==========");
            }

            Console.ReadLine();
        }
    }
}
