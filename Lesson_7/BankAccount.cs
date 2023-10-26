using System;

namespace Lesson_7
{
    public enum BankAccountType
    {
        Savings,
        Deposit
    }
    public class BankAccount
    {
        private static int accountNumberSeed = 0;
        private int accountNumber;
        private decimal balance;
        private BankAccountType bankAccountType;

        public BankAccount(decimal initialBalance, BankAccountType bankAccountType)
        {
            accountNumber = GenerateAccountNumber();
            balance = initialBalance;
            this.bankAccountType = bankAccountType;
        }

        public int GetAccountNumber
        {
            get { return accountNumber; }
        }

        public decimal GetBalance
        {
            get { return balance; }
        }

        public BankAccountType BankAccountType
        {
            get { return BankAccountType; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Зачислено на счет {accountNumber}: {amount} руб ");
            }
            else
            {
                Console.WriteLine("Ты бы хоть заработал, прежде чем на счет свои копейки закидывать.");
            }
        }

        public void WithDraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Снято со счета {accountNumber}: {amount} руб");
            }
            else
            {
                Console.WriteLine("А денежек то нет");
            }
        }

        public void Transfer(BankAccount toAccount, decimal amount)
        {
            if (amount > 0 && balance >= amount)
            {
                WithDraw(amount);
                toAccount.Deposit(amount);
                Console.WriteLine($"Перечислена cо счета {accountNumber} на счет {toAccount.accountNumber} сумма в размере {amount} \n");
            }
            else
            {
                Console.WriteLine("Вы ввели некорректную сумму.");
            }
        }

        public void PrintInfoAboutAccount()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Баланс: {balance} руб");
            Console.WriteLine($"Тип банковского счета: {bankAccountType} \n");
        }

        private int GenerateAccountNumber()
        {
            int newAccountNumber = accountNumberSeed++;
            return newAccountNumber;
        }

    }
}
