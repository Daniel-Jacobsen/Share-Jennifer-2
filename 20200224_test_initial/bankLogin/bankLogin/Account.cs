using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankLogin
{
    public class Account
    {
        //fields
        private string _accountNumber;

        private string _pin;
        private string _name;
        private decimal _balance;

        //constructors
        public Account()
        {
        }

        public Account(string accountNumber, string pin, string name, decimal balance)
        {
            _accountNumber = accountNumber;
            _pin = pin;
            _name = name;
            _balance = balance;
        }

        //methods
        public string GetAccountNumber()
        {
            return _accountNumber;
        }

        public string GetPIN()
        { return _pin; }

        public string GetName()
        {
            return _name;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void MakeDeposit(decimal amount)
        {
            _balance += amount;
        }

        public void MakeWithDrawal(decimal amount)
        {
            _balance -= amount;
        }
    }
}