using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap02_2842
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList list = new BookList();
            list.add();
            list.show();

            Console.ReadLine();
        }
    }
}
