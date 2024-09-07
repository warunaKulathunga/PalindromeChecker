using System;

namespace PalindromeCheckerApp
{
    public class PalindromeChecker
    { 
        public bool IsPalindrome(string inputString, string trashSymbols)
        {
            
            int left = 0;
            int right = inputString.Length - 1;

            HashSet<char> trashSet = new HashSet<char>(trashSymbols);

            while (left < right)
            {
                
                while (left < right && trashSet.Contains(inputString[left]))
                {
                    left++;
                }

                while (left < right && trashSet.Contains(inputString[right]))
                {
                    right--;
                }

                if (char.ToLower(inputString[left]) != char.ToLower(inputString[right]))
                {
                    return false;
                }

                left++;
                right--;
            }
            
            return true;
        }
    }
}