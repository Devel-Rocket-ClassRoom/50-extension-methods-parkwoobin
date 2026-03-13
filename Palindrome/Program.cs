using System;
using System.Linq;

Console.WriteLine("=== 회문 판별 테스트 ===");
Console.WriteLine($"\"토마토\" -> {"토마토".IsPalindrome()}");
Console.WriteLine($"\"기러기\" -> {"기러기".IsPalindrome()}");
Console.WriteLine($"\"level\" -> {"level".IsPalindrome()}");
Console.WriteLine($"\"Level\" -> {"Level".IsPalindrome()}");
Console.WriteLine($"\"A man, a plan, a canal: Panama\" -> {"A man, a plan, a canal: Panama".IsPalindrome()}");
Console.WriteLine($"\"race a car\" -> {"race a car".IsPalindrome()}");
Console.WriteLine($"\"hello\" -> {"hello".IsPalindrome()}");
Console.WriteLine($"\"가나다\" -> {"가나다".IsPalindrome()}");
Console.WriteLine($"\"\" -> {"".IsPalindrome()}");

public static class StringExtensions
{
    public static bool IsPalindrome(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return false;
        }

        string cleaned = new string(text.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        string reversed = new string(cleaned.Reverse().ToArray());

        return cleaned == reversed;
    }
}