using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
           //CLEAN CODE
            
            UserInfo();
            UserSelect();



        }
        public static void UserInfo()
        {
            Console.WriteLine("What is your banks name?");
            string bankName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome to \n{bankName.ToUpper()}");
            Console.WriteLine();
            Console.WriteLine("what would you like to do today");
            Console.WriteLine(" Checking: \n Saving: \n Deposit: \n Withdraw:");
            Console.WriteLine("Enter Activity Name");




        }
        public static void UserSelect()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice.ToLower())
            {
                case "checking":
                    UserBankCheck();
                    break;
                case "saving":
                    UserBankSave();
                    break;
                case "deposit":
                    UserBankAdd();
                    break;
                case "withdraw":
                    Console.WriteLine("<You do not have Access rights>");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;


            }
        }
        public static void UserBankCheck()
        {
            BankAccount.GetBalance();

        }

        public static void UserBankSave()
        {
            BankAccount.GetSaving();
        }

        public static void UserBankAdd()
        {
            Console.WriteLine();
            Console.WriteLine("Checking: \nSaving:");

            string pickOne = Console.ReadLine();
            switch (pickOne.ToLower())
            {
                case "checking":
                    Console.WriteLine("Enter amount you want to Deposit");
                    BankAccountCheck();
                    Console.WriteLine("your new balance is");
                    UserBankCheck();
                    break;
                case "saving":
                    Console.WriteLine("Enter amount you want to Deposit");
                    BankAccountSave();
                    Console.WriteLine($"your new balance is");
                    UserBankSave();
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
        }
        public static void BankAccountCheck()
        {

            double amount = Double.Parse(Console.ReadLine());
            BankAccount accountCheck = new BankAccount();
            accountCheck.Deposit(amount);

        }
        public static void BankAccountSave()
        {
            double amount = Double.Parse(Console.ReadLine());
            BankAccount accountSave = new BankAccount();
            accountSave.SaveDeposit(amount);
        }
    }
}
