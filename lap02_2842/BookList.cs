using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap02_2842
{
    class BookList
    {
        List<Book> bookList = new List<Book>();

        public void add()
        {
            Console.Write("Nhap so sach: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                Book b = new Book();
                b.input();
                bookList.Add(b);
            }
        }

        public void show()
        {
            foreach (Book b in bookList)
                b.show();
        }
    }
}
