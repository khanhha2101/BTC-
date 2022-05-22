using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap02_2842
{
    interface IBook
    {
        string id { get; set;}
        string tacgia { get; set; }
        string tensach { get; set; }
        string nxb { get; set; }

        void show();
    }
}
