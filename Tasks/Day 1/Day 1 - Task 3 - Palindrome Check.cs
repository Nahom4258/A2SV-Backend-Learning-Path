class Task3PalindromeCheck
{
    public void Task3PalindromeCheck()
    {
        System.Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int left_ptr = 0, right_ptr = input.Length - 1;

        bool isPalindrome = true;

        while (left_ptr < right_ptr)
        {
            if (input[left_ptr] != input[right_ptr])
            {
                isPalindrome = false;
                break;
            }

            left_ptr += 1;
            right_ptr -= 1;
        }

        System.Console.WriteLine(isPalindrome ? $"{input} is PALINDROME!" : $"{input} is NOT Palindrome!!");
    }
}