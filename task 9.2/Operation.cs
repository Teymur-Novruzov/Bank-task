using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._2
{
    public class Operation:Banks_piece
    {
        public string Proses_name { get; set; }
        public string Date_time { get; set; }
        public Operation()
        {
            this.Proses_name = " Empty ";
            this.Date_time = " Empty ";
        }
        public Operation(string new_proses_name)
        {
            this.Proses_name = new_proses_name;
            this.Date_time = DateTime.Now.ToString();
        }
    }
}
