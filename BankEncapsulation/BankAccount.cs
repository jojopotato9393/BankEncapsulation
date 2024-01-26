using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private static double _balance = 0;

        private static double _savings = 0;

        public  void Deposit(double Money)
        {
            _balance += Money;
        }
        public void SaveDeposit(double Money) 
        {
            _savings += Money;
        }
        private void _withdrawChecking(double Money) 
        {
            _balance -= Money;
        }
        private void _withdrawSaving(double Money)
        {
            _savings -= Money;
        }
        public static void GetBalance()
        {
            Console.WriteLine(_balance);
        }
        public static void GetSaving()
        {
            Console.WriteLine( _savings);
        }
    }
}
