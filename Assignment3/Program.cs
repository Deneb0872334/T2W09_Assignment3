using System.Xml.Linq;

namespace Assignment3
{
    class Banking
    {
        public static void Main(string[] args)
        {
            // new keyword is for creating a new instance of the class
            BankAccount testAccoount01 = new BankAccount("121212");
            BankAccount testAccoount02 = new BankAccount("343434", 1000);
            BankAccount testAccoount03 = new BankAccount("565656", BankAccount.Type.Savings);

            Console.WriteLine(testAccoount01.ToString());
            Console.WriteLine(testAccoount02.ToString());
            Console.WriteLine(testAccoount03.ToString());

            testAccoount01.Deposit(150);
            testAccoount02.Withdraw(100);
            Console.WriteLine(testAccoount01.ToString());
            Console.WriteLine(testAccoount02.ToString());
        }
    }
}