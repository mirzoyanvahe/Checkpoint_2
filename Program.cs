using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to input a string
        Console.WriteLine("Enter a string to check if it is a palindrome:");

        // Read the user input and convert it to lowercase to make the check case-insensitive
        string input = Console.ReadLine().ToLower();

        // Call the IsPalindrome function to check if the input string is a palindrome
        bool result = IsPalindrome(input);

        // Output the result to the console
        Console.WriteLine("Is the string a palindrome? " + result);
    }

    // Function to check if a string is a palindrome
    static bool IsPalindrome(string str)
    {
        // Initialize two pointers, one at the start and one at the end of the string
        int start = 0;
        int end = str.Length - 1;

        // Loop through the string until the two pointers meet in the middle
        while (start < end)
        {
            // If characters at the start and end do not match, it's not a palindrome
            if (str[start] != str[end])
            {
                return false;  // Return false if mismatch is found
            }

            // Move the start pointer forward and the end pointer backward
            start++;
            end--;
        }

        // If no mismatches are found, return true as the string is a palindrome
        return true;
    }
}