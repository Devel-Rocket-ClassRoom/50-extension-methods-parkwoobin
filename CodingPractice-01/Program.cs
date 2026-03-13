using System;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.



string message = "안녕하세요 반갑습니다";
int count = StringHelper.CountWords(message);
Console.WriteLine($"단어 개수: {count}");

string message1 = "안녕하세요 반갑습니다";
int count1 = message1.CountWords();
Console.WriteLine($"단어 개수: {count1}");

Console.WriteLine($"10은(는) 짝수인가? {10.IsEven()}");
Console.WriteLine($"7은(는) 홀수인가? {7.IsOdd()}");
Console.WriteLine($"3을 5번 반복: {3.Repeat(5)}");

public static class StringHelper
{
    public static int CountWords(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0;
        }
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}


public static class StringExtensions
{
    public static int CountWords(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0;
        }
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }
    public static string Repeat(this int number, int times)
    {
        return string.Concat(Enumerable.Repeat(number.ToString(), times));
    }
}