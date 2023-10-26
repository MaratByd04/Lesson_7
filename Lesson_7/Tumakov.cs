using System;
using System.Globalization;
using System.IO;

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

            Console.WriteLine("Нажмите что-нибудь для перехода к следующей задаче.");
            Console.ReadKey();
            Console.Clear();
        }
        static void Zadanie2()
        {
            Console.WriteLine("Упражнение 8.2. Переворот строки.\n");

            Console.WriteLine("Введите строку, которую желаете перевернуть.");
            string str = Console.ReadLine();
            string revers = ReverseString(str);
            Console.WriteLine(revers + "\n");

            Console.ReadKey();
            Console.Clear();
        }
        static void Zadanie3()
        {
            Console.WriteLine("Введите название файла. (Для проверки работы программы введите *текст.txt*)");
            string inputFilename = Console.ReadLine();
            if (!File.Exists(inputFilename)) 
            {
                Console.WriteLine("Файла с таким наименованием не существует.");
            }
            else
            {
                try
                {
                    string outputFilename = "output.txt";
                    string content = File.ReadAllText(inputFilename);
                    string uppercaseContent = content.ToUpper();
                    File.WriteAllText(outputFilename, uppercaseContent);
                    

                    Console.WriteLine($"Содержимое файла '{inputFilename}' успешно записано в файл '{outputFilename}' в верхнем регистре.");
                    Console.WriteLine(File.ReadAllText(outputFilename));
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
            Console.ReadKey();
        }
    }
}
