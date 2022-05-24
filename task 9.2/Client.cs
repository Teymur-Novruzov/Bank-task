using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._2
{
    class Client:Human
    {
        public Credit Credit;
        public string Live_address { get; set; }
        public string Work_address { get; set; }
        public double Salary { get; set; }
        public Client()
        {
            this.Live_address = " Empty ";
            this.Work_address = " Empty ";
            this.Salary =0;
        }
        public Client(string new_live_address,string new_work_address,double new_salary)
        {
            this.Live_address = new_live_address;
            this.Work_address = new_work_address;
            this.Salary = new_salary;
        }
        public void Show_client()
        {

        }
    }
}
