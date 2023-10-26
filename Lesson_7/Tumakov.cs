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
                Console.ReadKey();
                Console.Clear();

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
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        // метод для дз 8.1
        public static void SearchMail(ref string s)
        {
            int index = s.IndexOf('#');
            if (index != -1 && index < s.Length - 1)
            {
                s = s.Substring(index + 1).Trim();
            }
            else
            {
                s = string.Empty;
            }
        }
        public static void CreateEmailListFile(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            string[] emails = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string email = lines[i];
                SearchMail(ref email);
                emails[i] = email;
            }

            File.WriteAllLines(outputFilePath, emails);
        }
        static void Zadanie4()
        {
            string inputFilePath = "input.txt"; 
            string outputFilePath = "output.txt"; 

            CreateEmailListFile(inputFilePath, outputFilePath);

            Console.WriteLine("Адреса электронной почты успешно извлечены и записаны в новый файл.");
            Console.WriteLine(File.ReadAllText(outputFilePath));
        } // все еще он
       
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
            Zadanie4();
            Console.ReadKey();
        }
    }
}
