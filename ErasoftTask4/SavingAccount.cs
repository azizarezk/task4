using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErasoftTask4;

     class SavingAccount :Account
    {
        public SavingAccount(string name = "Saveing Account", double balance=0.0, double fee=0.0) 
            : base( name, balance)
        {
            Fee = fee;
        }

        public double Fee { get; set; }

        public override bool Withdraw(double amount) => base.Withdraw(amount + (amount * Fee));

        public override string ToString()
        {
            return $"{base.ToString()}, Fee: {Fee}";
        }
    }

