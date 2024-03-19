using System;
using System.Xml.Linq;

namespace Assignment3
{
	public class BankAccount
	{
        /*
		  - Account Number
		  - Balance
		  - Type
		 */
        private string accountNumber;
        private double balance;
        private Type accountType = Type.Checking;

        // the complete constructor to be called by the others
        private BankAccount(string paramAccountNumber, double paramBalance, Type paramType)
        {
            this.accountNumber = paramAccountNumber;
            this.balance = paramBalance;
            this.accountType = paramType;
        }

        // delegating the construction of the instance to the other constructor
        public BankAccount(string paramAccountNumber, double paramBalance) : this(paramAccountNumber, paramBalance, Type.Checking)
        { }

        public BankAccount(string paramAccountNumber, Type paramType) : this(paramAccountNumber, 0.00, paramType)
        { }

        public BankAccount(string paramAccountNumber) : this(paramAccountNumber, 0.00, Type.Checking)
        { }

        public string AccountNumber   // property
        {
            get { return accountNumber; }   // get method
        }

        public double Balance   // property
        {
            get { return balance; }   // get method
        }

        public Type AccountType   // property
        {
            get { return accountType; }   // get method
        }

        public override string ToString()
        {
            return "Account Number: " + this.accountNumber + "\nBalance: $" + this.balance;
        }

        public void Deposit(double paramAmount)
        {
            this.balance += paramAmount;
        }

        // Default Deposit
        public void Deposit()
        {
            this.balance += 100;
        }

        public bool Withdraw(double paramAmount)
        {
            if (this.balance > paramAmount)
            {
                this.balance -= paramAmount;
                return true;
            } else
            {
                return false;
            }
        }

        // Default Withdraw amount
        public bool Withdraw()
        {
            
            if (this.balance > 100)
            {
                this.balance -= 100;
                return true;
            }
            else
            {
                return false;
            }
        }

        public enum Type { Checking, Savings }
    }
}

