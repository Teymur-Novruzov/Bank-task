using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._2
{
    class CEO:Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public CEO()
        {
            this.Position = " Empty ";
            this.Salary = 0;
        }
        public CEO(string new_position,double new_salary)
        {
            this.Position = new_position;
            this.Salary = new_salary;
        }
        public void Control()
        {
            for (int i = 0; i < 2; i++)
            {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("         Control ");

            }
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
        public void MakeMeeting()
        {
            for (int i = 0; i < 2; i++)
            {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("         Organize ");

            }
        }
        public void DecreasePercentage(Credit credit,int new_percent)
        {
            credit.Percent = new_percent;
            for (int i = 0; i < 2; i++)
            {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("         Success ");

            }
        }
    }
}
