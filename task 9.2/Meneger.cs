using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._2
{
    public class Meneger:Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public Meneger()
        {
            this.Position = " Empty ";
            this.Salary = 0;
        }
        public Meneger(string new_position,double new_salary)
        {
            this.Position = new_position;
            this.Salary = new_salary;
        }
        public void Organize()
        {
            for (int i = 0; i < 2; i++)
            {
            
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("         Organize ");

            }
        }
        public void Calculate_Salarys()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"   Salary : {this.Salary}");

        }
    }
}
