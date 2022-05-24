using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._2
{
    class Credit:Banks_piece
    {
        public double Amont { get; set; }//mebleq
        public int Percent { get; set; }//faiz
        public int Months { get; set; }
        public double Payment { get; set; }//odenis
        public Credit()
        {
            this.Amont = 0;
            this.Percent = 0;
            this.Months = 0;
            this.Payment = 0;
        }
        public Credit(double new_Amont,int new_percent,int new_months)
        {
            this.Amont = new_Amont;
            this.Percent = new_percent;
            this.Months = new_months;
            this.Payment =((this.Amont/this.Months)*this.Percent)/100;
        }

        public void CalculatePercent()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"   Percent money : {((this.Amont*this.Payment)/100)*this.Months}");
        }
        public void Show_Credit()
        {
            Console.WriteLine($"   Amont : {this.Amont}");
            Console.WriteLine($"   Percent : {this.Percent}");
            Console.WriteLine($"   Months : {this.Months}");
            Console.WriteLine($"   Payment : {this.Payment}");
        }
    }
}
