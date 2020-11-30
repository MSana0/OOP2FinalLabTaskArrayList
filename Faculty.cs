using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalLabTask
{
    class Faculty
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Faculty() { }
        public Faculty(string name, string id)
        {
            Name = name;
            Id = id;
        }
        public void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
        }
    }
}
