using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount();
            bankAccount1.accountNumber = 123456;
            bankAccount1.balance = 1000;
            bankAccount1.SetbankAccountType("Checking");
            Console.WriteLine($"Номер Вашего счета набитый вручную {bankAccount1.accountNumber}, Номер Вашего счета сформированный автоматически {bankAccount1.GetAccountNumberGenerator()},  Ваш баланс {bankAccount1.balance}, тип счета {bankAccount1.GetbankAccountType()}");
            Console.ReadLine();

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.accountNumber = 654321;
            bankAccount2.balance = 3000;
            bankAccount2.SetbankAccountType("Savings");
            Console.WriteLine($"Номер Вашего счета набитый вручную {bankAccount2.accountNumber}, Номер Вашего счета сформированный автоматически {bankAccount2.GetAccountNumberGenerator()},  Ваш баланс {bankAccount2.balance}, тип счета {bankAccount2.GetbankAccountType()}");
            Console.ReadLine();

            BankAccount bankAccount3 = new BankAccount(1000, "Checking");
            Console.WriteLine($"Номер Вашего счета набитый вручную {bankAccount3.accountNumber}, Номер Вашего счета сформированный автоматически {bankAccount3.GetAccountNumberGenerator()},  Ваш баланс {bankAccount3.balance}, тип счета {bankAccount3.GetbankAccountType()}");
            Console.ReadLine();
        }
    } 

    class BankAccount
    {
        public int accountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        public int balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        private static int accountNumberGenerator = 0;

        public BankAccount(int balance)
        {
            this.balance = balance;
        }

        public BankAccount(string accountType)
        {
            SetbankAccountType(accountType);
            accountNumberGenerator++;
        }

        public BankAccount(int balance, string accountType)
        {
            this.balance = balance;
            SetbankAccountType(accountType);
            accountNumberGenerator++;
        }


        public enum BankAccountType
        {
            Checking,
            Savings
        }

        private BankAccountType bankAccountType;

        public BankAccount() { accountNumberGenerator++;}

        public int GetAccountNumberGenerator()
        {
            return accountNumberGenerator;
        }

        public void SetbankAccountType(string accountType)
        {
            if (accountType == "Checking")
            {
                bankAccountType = BankAccountType.Checking;
            }else if (accountType == "Savings")
            {
                bankAccountType = BankAccountType.Savings;
            }
            
        }

        public BankAccountType GetbankAccountType()
        {
            return bankAccountType;
        }

        public bool Withdraw(int many)
        {
            if (many >= balance)
            {
                balance -= many;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Todeposit(int many)
        {
            balance += many;
        }


    }
}
