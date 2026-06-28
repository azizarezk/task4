using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErasoftTask4;

     class SavingAccount :Account
    {
        public SavingAccount(string name = "Saveing Account", double balance=0.0, double interestrate = 0.0) 
            : base( name, balance)
        {
        InterestRate = interestrate;
        }

        public double InterestRate { get; set; }

        public override bool Withdraw(double amount) => base.Withdraw(amount + (amount * (InterestRate/100)));

        public override string ToString()
        {
            return $"{base.ToString()}, Fee: {Fee}";
        }
    }

