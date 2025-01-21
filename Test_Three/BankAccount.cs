using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Three
{

    public class BankAccount //липсваше деклариран клас
    {

        private int id;
        private decimal balance;
        private double amount; //declared amoiunt
        public BankAccount(int id, decimal balance) //added id and balance parameters
        {
            Id = id;
            Balance = balance;
        }
        public int Id //added Id
        {
            get { return id; }
            private set { id = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }
        public void Deposit(decimal amount)//added decimal amount
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount must be positive number!");
            }
            this.Balance += amount;// added this
        }
        public void Withdraw(decimal amount)
        {
            if (true)
            {
                Console.WriteLine("Insufficient Balance!");
            }
            this.Balance -= amount;
        }
        public override string ToString()
        {
            return $"Account {this.Id}, balance {this.Balance}"; //added $
        }
    }
}
