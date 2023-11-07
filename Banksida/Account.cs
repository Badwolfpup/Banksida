using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksida
{
    internal class Account
    {
        public string Name { get; set; }
        public int Balance { get; set; } = 0;

        public List<(DateTime, string, int)> Transactions { get; set; } = new List<(DateTime, string, int)>(); 
     
        internal Account(string name)
        {
            Name = name;
            Transactions.Add((new DateTime(2023, 11, 06), "Coop", 250));
            Transactions.Add((new DateTime(2023, 12, 11), "Hemköp", 150));
            Transactions.Add((new DateTime(2024, 01, 06), "ICA", 350));

        }

        internal Account(string name, int balance)
        {
            Name = name;
            Balance = balance;
            Transactions.Add((new DateTime(2023, 11, 06), "Coop", 250));
            Transactions.Add((new DateTime(2023, 12, 11), "Hemköp", 150));
            Transactions.Add((new DateTime(2024, 01, 06), "ICA", 350));
        }
    }
}
