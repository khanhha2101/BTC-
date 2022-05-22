using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap01_9033
{
    class Student
    {
        string SID;
        string hoten;
        string khoa;
        string dtb;

        public Student() { }

        public Student(string sID1, string hoten, string khoa, string dtb)
        {
            SID1 = sID1;
            Hoten = hoten;
            Khoa = khoa;
            Dtb = dtb;
        }

        public string SID1 { get => SID; set => SID = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string Dtb { get => dtb; set => dtb = value; }

        public void show()
        {
            Console.WriteLine("SID: " + SID);
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Khoa: " + khoa);
            Console.WriteLine("Diem trung binh: " + dtb);
        }
    }
}
