using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalLabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty f = new Faculty("Mahbub Chowdhury Mishu.","984651");
            Faculty f1 = new Faculty("Dr. Dip Nandi.", "5165415");
            Dept d = new Dept("CSE", "1");
            d.AddFaculty(f, f1);
            d.ShowAll();
        }
    }
}
