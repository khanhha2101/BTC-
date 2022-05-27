using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap02_2842
{
    class Book : IBook
    {
        string tacGia;
        string tenSach;
        string Nxb;

        public string tacgia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string tensach { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string nxb { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void show()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Ten sach: " + tenSach);
            Console.WriteLine("Tac gia: " + tacGia);
            Console.WriteLine("Nam xuat ban: " + Nxb);
            Console.WriteLine("--------------------");
        }

        public void input()
        {
            Console.Write("Nhap ten sach: ");
            tenSach = Console.ReadLine();
            Console.Write("Nhap tac gia: ");
            tacGia = Console.ReadLine();
            Console.Write("Nhap nam xuat ban: ");
            Nxb = Console.ReadLine();
        }
    }
}
