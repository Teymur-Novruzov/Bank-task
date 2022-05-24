using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._2
{
    class Bank
    {
        public CEO ceo;
        public Worker[] workers;
        public int workers_count { get; set; }
        public Meneger[] menegers;
        public int menegers_count { get; set; }
        public Client[] clients; 
        public int clients_count { get; set; }
        public string Name { get; set; }
        public double Budget { get; set; } //budce
        public double Profit { get; set; } //gelir
        public Bank()
        {
            this.Name = " Empty ";
            this.Budget = 0;
            this.Profit = 0;
            this.workers_count = 0;
            this.menegers_count = 0;
            this.clients_count = 0;
        }
        public Bank(CEO new_ceo,string new_name, double new_budget, double new_profit)
        {
            this.ceo = new_ceo;
            this.Name = new_name;
            this.Budget = new_budget;
            this.Profit = new_profit;
            this.workers_count = 0;
            this.menegers_count = 0;
            this.clients_count = 0;
        }

        public void Add_worker(Worker new_worker)
        {
            workers[workers_count++] = new_worker;
        }
        public void Add_maneger(Meneger new_meneger)
        {
            menegers[menegers_count++] = new_meneger;
        }
        public void Add_client(Client new_client)
        {
            clients[clients_count++] = new_client;
        }
        
        public void ShowClientCredit(string fullname)
        {
            if (this.clients_count != 0)
            {
                for (int i = 0; i <this.clients_count;  i++)
                {
                    if (clients[i].Name == fullname)
                    {
                        clients[i].Show_human();
                        clients[i].Show_client();
                        clients[i].Credit.Show_Credit();
                        Console.WriteLine();
                    }
                }
            }
            
        }
        public void Calculate_Profil()
        {
            for (int i = 0; i < 2; i++)
            {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("         Profil Calculated ");

            }
        }
        public void PayCredit(Client client,double money)
        {
            client.Credit.Amont -= money;
            if (client.Credit.Amont < 0)
            {
                client.Credit.Amont = 0;
            }
            
        }
        public void ShowAllCredit()
        {
            if (this.clients_count != 0)
            {
                for (int i = 0; i < this.clients_count; i++)
                {
                    clients[i].Show_human();
                    clients[i].Show_client();
                    clients[i].Credit.Show_Credit();
                    Console.WriteLine();
                }
            }
        }

    }
}
