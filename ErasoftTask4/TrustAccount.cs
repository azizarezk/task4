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
        Count++;
    }

    public double Fee { get; set; }
    public int Year { get; set; }
    public int Count { get; set; }

    public override bool Deposit(double amount) => base.Deposit(amount >= 5000 ? amount + Fee : amount);
    public override bool Withdraw(double amount) => base.Withdraw(( Count<3&& amount > .20 * balance) ? 0 : amount);

    public override string ToString()
    {
        return $"{base.ToString()}, Fee: {Fee}";
    }
}

