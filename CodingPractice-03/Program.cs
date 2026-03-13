using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.


string message = "hello";
Console.WriteLine($"'{message}'는 대문자로 되어 있나요? {message.IsCapitalized()}");
Console.WriteLine($"첫 글자 대문자: {message.Capitalize()}");
Console.WriteLine($"문자열 뒤집기: {message.Reverse()}");


string text = "안녕하세요 반갑습니다 좋은 하루 되세요";
string result = text
    .Take(10)
    .AddEllipsis()
    .AddPrefix("[메시지] ")
    .AddSuffix(" (더보기)");

Console.WriteLine($"원본: {text}");
Console.WriteLine($"결과: {result}");


List<string> names = new() { "철수", "영희", "민수" };
List<int> emptyList = new();
Console.WriteLine($"names 비어있음? {names.IsEmpty()}");
Console.WriteLine($"emptyList 비어있음? {emptyList.IsEmpty()}");
Console.WriteLine($"names에 요소 있음? {names.HasItems()}");

Console.WriteLine("\n이름 목록:");
names.ForEach(name => Console.WriteLine($"  - {name}"));


public static class StringExtensions
{
    public static bool IsCapitalized(this string text)
    {
        if (text[0].ToString().ToUpper() == text[0].ToString())
        {
            return true;
        }
        return false;
    }
    public static string Capitalize(this string text)
    {
        return text[0].ToString().ToUpper() + text.Substring(1);
    }
    public static string Reverse(this string text)
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}


public static class StringChainExtensions
{
    public static string AddPrefix(this string text, string prefix)
    {
        return prefix + text;
    }
    public static string AddSuffix(this string text, string suffix)
    {
        return text + suffix;
    }
    public static string Take(this string text, int count)
    {
        if (count < 0 || count > text.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "count는 0 이상이고 문자열 길이 이하이어야 합니다.");
        }
        return text.Substring(0, count);
    }
    public static string AddEllipsis(this string text)
    {
        return text + "...";
    }
}

public static class CollectionExtensions
{
    public static bool IsEmpty<T>(this ICollection<T> collection)
    {
        return collection.Count == 0;
    }
    public static bool HasItems<T>(this ICollection<T> collection)
    {
        return collection.Count > 0;
    }
    public static void ForEach<T>(this IList<T> list, Action<T> action)
    {
        for (int i = 0; i < list.Count; i++)
        {
            action(list[i]);
        }
    }
}
