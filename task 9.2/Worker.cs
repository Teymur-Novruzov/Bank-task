using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._2
{
    public class Worker:Human
    {
        public Operation[] operations;
        public int Operations_count { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string Start_time { get; set; }
        public string End_time { get; set; }

        public Worker()
        {
            this.Position = " Empty ";
            this.Salary = 0;
            this.Start_time = " Empty ";
            this.End_time = " Empty ";
        }
        public Worker(string new_position, double new_salary, string new_start_time, string new_end_time)
        {
            this.Position = new_position;
            this.Salary = new_salary;
            this.Start_time = new_start_time;
            this.End_time = new_end_time;
        }
        public void Add_operation(string operations_name)
        {
            Operation new_operation = new Operation(operations_name);
            operations[Operations_count++] = new_operation;
        }

    }
}
