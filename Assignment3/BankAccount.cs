using System;
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
        private Type type = Type.Checking;

        // the constructor is supposed to be public to be accessed from outside of the class
        private BankAccount(string paramAccountNumber, double paramBalance, Type paramType)
        {
            this.accountNumber = paramAccountNumber;
            this.balance = paramBalance;
            this.type = paramType;
        }

        // delegating the construction of the instance to the other constructor
        private BankAccount(string paramAccountNumber, double paramBalance) : this(paramAccountNumber, paramBalance, Type.Checking)
        { }

        public BankAccount()
        { }

        public void Deposit(double paramAmount)
        { }

        public bool Withdraw(double paramAmount)
        {
            return true;
        }

        public enum Type { Checking, Savings }
    }
}

