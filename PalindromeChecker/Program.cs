using System;

namespace PalindromeCheckerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PalindromeChecker checker = new PalindromeChecker();

            string inputString1 = "a@b!!b$a";
            string trashSymbols1 = "!@$";
            bool result1 = checker.IsPalindrome(inputString1, trashSymbols1);
            Console.WriteLine($"Is \"{inputString1}\" a palindrome? {result1}");

            string inputString2 = "?Aa#c";
            string trashSymbols2 = "#?";
            bool result2 = checker.IsPalindrome(inputString2, trashSymbols2);
            Console.WriteLine($"Is \"{inputString2}\" a palindrome? {result2}");

            Console.WriteLine("Enter Input String:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter Trash Symbols:");
            string trashSymbols = Console.ReadLine();

            bool result = checker.IsPalindrome(inputString, trashSymbols);
            Console.WriteLine($"Is \"{inputString}\" a palindrome? {result}");

        }
    }
}
