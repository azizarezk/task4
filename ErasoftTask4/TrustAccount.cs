using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErasoftTask4;

class TrustAccount : Account
{
    public TrustAccount(string name = "Trust Account", double balance = 0.0, double fee = 50)
        : base(name, balance)
    {
        Fee = fee;
        Year = DateTime.Now.Year;
        
    }

    public double Fee { get; set; }
    public int Year { get; set; }
    private int Count { get; set; }

    public override bool Deposit(double amount) => base.Deposit(amount >= 5000 ? amount + Fee : amount);
    // public override bool Withdraw(double amount) => base.Withdraw(( Count<3&& amount > .20 * balance) ? 0 : amount);
    public override bool Withdraw(double amount)
    {
        if (Count >= 3)
            return false;

        if (amount > balance * 0.20)
            return false;

        if (base.Withdraw(amount))
        {
            Count++;
            return true;
        }

        return false;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, Fee: {Fee}";
    }
}

