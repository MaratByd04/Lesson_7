using System;

namespace Lesson_7
{
    internal class Tumakov
    {
        public static string ReverseString(string input) // метод для упражнения 8.2
        {
            char[] someArray = input.ToCharArray();
            Array.Reverse(someArray);
            return new string(someArray);
        }
        static void Zadanie1()
        {
            Console.WriteLine("Упражнение 8.1. Банковский счет.\n");
            BankAccount account1 = new BankAccount(1000666, BankAccountType.Deposit);
            BankAccount account2 = new BankAccount(15003456, BankAccountType.Savings);

            account1.PrintInfoAboutAccount();
            account2.PrintInfoAboutAccount();

            account1.Transfer(account2, 1282);

            account1.PrintInfoAboutAccount();
            account2.PrintInfoAboutAccount();
        }
        static void Zadanie2()
        {
            Console.WriteLine("Упражнение 8.2. Переворот строки.\n");

            Console.WriteLine("Введите строку, которую желаете перевернуть.");
            string str = Console.ReadLine();
            string revers = ReverseString(str);
            Console.WriteLine(revers);
        }
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
            Console.ReadKey();
        }
    }
}
