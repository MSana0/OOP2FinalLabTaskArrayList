using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOP2FinalLabTask
{
    class Dept
    {
        public string Name { get; set; }
        public string Id { get; set; }

        ArrayList faculties;
        
        public Dept()
        {
            faculties = new ArrayList();
        }
        public Dept(string name, string id)
        {
            Name = name;
            Id = id;
            faculties = new ArrayList();
        }
        public void AddFaculty(params Faculty[] faculties)
        {
            foreach(Faculty f in faculties)
            {
                this.faculties.Add(f);
            }
        }
        /*public void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
        }*/
        public void ShowAll()
        {
            foreach(Faculty f in faculties)
            {
                f.Show();
            }
        }
    }
}
