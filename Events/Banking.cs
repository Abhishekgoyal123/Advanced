using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void TransactionEventhandler();
    public class Banking
    {
        decimal NetBalance = 0;

        public event TransactionEventhandler OverBalance_Event;
        public event TransactionEventhandler UnderBalance_Event;

        public Banking(decimal netBalance)
        {
            NetBalance = netBalance;
        }

        public void Deposit(decimal amount)
        {
            NetBalance = NetBalance + amount;

            if(NetBalance > 100000)
            {
                OverBalance_Event();
            }

        }

        public void Withdraw(decimal amount)
        {
            NetBalance = NetBalance - amount;

            if (NetBalance <5000)
            {
                UnderBalance_Event();
            }

        }

        public decimal GetNetBalance()
        {
            return NetBalance;
        }
    }
}
