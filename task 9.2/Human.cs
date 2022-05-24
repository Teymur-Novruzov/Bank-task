using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._2
{
    public class Human
    {
        public int GUID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Human()
        {
            this.Name = " Empty ";
            this.Surname = " Empty ";
            this.Age = 0;
        }
        public Human(int new_guid, string new_name, string new_surname, int new_age)
        {
            this.GUID = new_guid;
            this.Name = new_name;
            this.Surname = new_surname;
            this.Age = new_age;
        }
        public void Show_human()
        {
            Console.WriteLine($"   GUID : {this.GUID}");
            Console.WriteLine($"   Name : {this.Name}");
            Console.WriteLine($"   Surname : {this.Surname}");
            Console.WriteLine($"   Age : {this.Age}");
        }
    }
}
